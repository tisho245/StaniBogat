using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaniBogat1
{
    public partial class Form1 : Form
    {
        
        string connectionstring;
        SqlConnection connection;
        SqlDataReader reader;
        int totalPoints = 0;
        List<int> usedQuestionIds = new List<int>();
        Timer animationTimer = new Timer();
        int animationCounter = 0;
        Label selectedAnswer = null;
        bool isCorrectAnswer = false;
        
       
        Timer waitTimer = new Timer();

        public Form1()
        {
            InitializeComponent();

     
            animationTimer.Interval = 300;
            animationTimer.Tick += AnimationTimer_Tick;

            waitTimer.Tick += WaitTimer_Tick;
            waitTimer.Interval = 1500; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            connectionstring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=stani_bogat;Integrated Security=True;";
            connection = new SqlConnection(connectionstring);
            connection.Open();
         //   MessageBox.Show("Има връзка с бази данни!"); 

            LoadRandomQuestion();

          
            lblPoints.Text = "Точки: 0";
        }

        private void LoadRandomQuestion()
        {

            SqlCommand countCmd = connection.CreateCommand();
            countCmd.CommandText = "SELECT COUNT(*) FROM Questions";


            if (reader != null && !reader.IsClosed)
                reader.Close();

            int totalQuestions = (int)countCmd.ExecuteScalar();



            if (usedQuestionIds.Count >= totalQuestions)
            {
                MessageBox.Show("Всички въпроси са използвани! Играта започва отначало.");
                usedQuestionIds.Clear();
            }

          
            SqlCommand query = connection.CreateCommand();

            
            string excludeClause = "";
            if (usedQuestionIds.Count > 0)
            {
                excludeClause = " WHERE id NOT IN (" + string.Join(",", usedQuestionIds) + ")";
            }

           
            query.CommandText = "SELECT TOP 1 * FROM Questions" + excludeClause + " ORDER BY NEWID()";

           
            reader = query.ExecuteReader();

            if (reader.Read())
            {
                
                int questionId = Convert.ToInt32(reader["id"]);
                if (!usedQuestionIds.Contains(questionId))
                {
                    usedQuestionIds.Add(questionId);
                }

               
                lblQuestion.Text = reader["Question"].ToString();
                lblAns1.Text = reader["ans1"].ToString();
                lblAns2.Text = reader["ans2"].ToString();
                lblAns3.Text = reader["ans3"].ToString();
                lblAns4.Text = reader["ans4"].ToString();

                
                lblAns1.BackColor = Color.Transparent;
                lblAns2.BackColor = Color.Transparent;
                lblAns3.BackColor = Color.Transparent;
                lblAns4.BackColor = Color.Transparent;
            }
            else
            {
                MessageBox.Show("Няма повече въпроси!");
            }

        }
    

        
        private void HandleAnswerClick(Label clickedLabel, int selectedAnswerIndex)
        {
            
            if (animationTimer.Enabled)
                return;

            if (reader != null && !reader.IsClosed)
            {
                selectedAnswer = clickedLabel;

            
                int correctAnswer = Convert.ToInt32(reader["correct"]);
                if (selectedAnswerIndex == correctAnswer)
                {
                    isCorrectAnswer = true;
                }
                else
                {
                    isCorrectAnswer = false;
                }

                
                animationCounter = 0;
                animationTimer.Start();
            }
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            
            if (animationCounter < 10)
            {
                if (animationCounter % 2 == 0)
                {
                    if (isCorrectAnswer)
                    {
                        selectedAnswer.BackColor = Color.Green;
                    }
                    else
                    {
                        selectedAnswer.BackColor = Color.Red;
                    }
                }
                else
                {
                    selectedAnswer.BackColor = Color.Transparent;
                }

                animationCounter++;
            }
            else
            {
                
                animationTimer.Stop();

                if (isCorrectAnswer)
                {
                    selectedAnswer.BackColor = Color.DarkGreen;
                }
                else
                {
                    selectedAnswer.BackColor = Color.DarkRed;
                }

                if (isCorrectAnswer)
                {
                    int points = Convert.ToInt32(reader["points"]);
                    totalPoints = totalPoints + points;
                    lblPoints.Text = "Точки: " + totalPoints;

                 
                    waitTimer.Interval = 1000; 
                    waitTimer.Start();
                }
                else
                {
                    int correctIndex = Convert.ToInt32(reader["correct"]);
                    Label correctLabel = null;

                    if (correctIndex == 1)
                    {
                        correctLabel = lblAns1;
                    }
                    else if (correctIndex == 2)
                    {
                        correctLabel = lblAns2;
                    }
                    else if (correctIndex == 3)
                    {
                        correctLabel = lblAns3;
                    }
                    else if (correctIndex == 4)
                    {
                        correctLabel = lblAns4;
                    }

                    if (correctLabel != null)
                    {
                        correctLabel.BackColor = Color.Green;
                    }

                   
                  //  MessageBox.Show($"Грешен отговор! Правилният отговор е: {correctLabel.Text}\nТочки: {totalPoints}");

                   
                    waitTimer.Interval = 1500; 
                    waitTimer.Start();
                }
            }
        }

        private void WaitTimer_Tick(object sender, EventArgs e)
        {

            waitTimer.Stop();

            LoadRandomQuestion();
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {
            
        }

        private void lblAnswer1_Click(object sender, EventArgs e)
        {
            HandleAnswerClick(lblAns1, 1);
        }

        private void lblAnswer2_Click(object sender, EventArgs e)
        {
            HandleAnswerClick(lblAns2, 2);
        }

        private void lblAnswer3_Click(object sender, EventArgs e)
        {
            HandleAnswerClick(lblAns3, 3);
        }

        private void lblAnswer4_Click(object sender, EventArgs e)
        {
            HandleAnswerClick(lblAns4, 4);
        }

        private void lblPoints_Click(object sender, EventArgs e)
        {
           
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Form2 form2  = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }       
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
          
            animationTimer.Stop();
            waitTimer.Stop();

            if (reader != null && !reader.IsClosed)
                reader.Close();

            if (connection != null && connection.State == ConnectionState.Open)
                connection.Close();
        }
    }
}