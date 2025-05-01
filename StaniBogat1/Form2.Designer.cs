namespace StaniBogat1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label questionLabel;
            System.Windows.Forms.Label ans1Label;
            System.Windows.Forms.Label ans2Label;
            System.Windows.Forms.Label ans3Label;
            System.Windows.Forms.Label ans4Label;
            System.Windows.Forms.Label correctLabel;
            System.Windows.Forms.Label pointsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.stani_bogatDataSet = new StaniBogat1.stani_bogatDataSet();
            this.stanibogatDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionsTableAdapter = new StaniBogat1.stani_bogatDataSetTableAdapters.QuestionsTableAdapter();
            this.tableAdapterManager = new StaniBogat1.stani_bogatDataSetTableAdapters.TableAdapterManager();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.ans1TextBox = new System.Windows.Forms.TextBox();
            this.ans2TextBox = new System.Windows.Forms.TextBox();
            this.ans3TextBox = new System.Windows.Forms.TextBox();
            this.ans4TextBox = new System.Windows.Forms.TextBox();
            this.correctTextBox = new System.Windows.Forms.TextBox();
            this.pointsTextBox = new System.Windows.Forms.TextBox();
            this.questionsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBackToGame = new System.Windows.Forms.Button();
            questionLabel = new System.Windows.Forms.Label();
            ans1Label = new System.Windows.Forms.Label();
            ans2Label = new System.Windows.Forms.Label();
            ans3Label = new System.Windows.Forms.Label();
            ans4Label = new System.Windows.Forms.Label();
            correctLabel = new System.Windows.Forms.Label();
            pointsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stani_bogatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanibogatDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Location = new System.Drawing.Point(90, 48);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new System.Drawing.Size(59, 16);
            questionLabel.TabIndex = 0;
            questionLabel.Text = "Въпрос:";
            // 
            // ans1Label
            // 
            ans1Label.AutoSize = true;
            ans1Label.Location = new System.Drawing.Point(77, 81);
            ans1Label.Name = "ans1Label";
            ans1Label.Size = new System.Drawing.Size(72, 16);
            ans1Label.TabIndex = 2;
            ans1Label.Text = "Отговор1:";
            // 
            // ans2Label
            // 
            ans2Label.AutoSize = true;
            ans2Label.Location = new System.Drawing.Point(77, 106);
            ans2Label.Name = "ans2Label";
            ans2Label.Size = new System.Drawing.Size(72, 16);
            ans2Label.TabIndex = 4;
            ans2Label.Text = "Отговор2:";
            // 
            // ans3Label
            // 
            ans3Label.AutoSize = true;
            ans3Label.Location = new System.Drawing.Point(77, 138);
            ans3Label.Name = "ans3Label";
            ans3Label.Size = new System.Drawing.Size(72, 16);
            ans3Label.TabIndex = 6;
            ans3Label.Text = "Отговор3:";
            // 
            // ans4Label
            // 
            ans4Label.AutoSize = true;
            ans4Label.Location = new System.Drawing.Point(77, 175);
            ans4Label.Name = "ans4Label";
            ans4Label.Size = new System.Drawing.Size(72, 16);
            ans4Label.TabIndex = 8;
            ans4Label.Text = "Отговор4:";
            // 
            // correctLabel
            // 
            correctLabel.AutoSize = true;
            correctLabel.Location = new System.Drawing.Point(54, 200);
            correctLabel.Name = "correctLabel";
            correctLabel.Size = new System.Drawing.Size(99, 16);
            correctLabel.TabIndex = 10;
            correctLabel.Text = "верен индекс:";
            // 
            // pointsLabel
            // 
            pointsLabel.AutoSize = true;
            pointsLabel.Location = new System.Drawing.Point(99, 232);
            pointsLabel.Name = "pointsLabel";
            pointsLabel.Size = new System.Drawing.Size(50, 16);
            pointsLabel.TabIndex = 12;
            pointsLabel.Text = "Точки:";
            // 
            // stani_bogatDataSet
            // 
            this.stani_bogatDataSet.DataSetName = "stani_bogatDataSet";
            this.stani_bogatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stanibogatDataSetBindingSource
            // 
            this.stanibogatDataSetBindingSource.DataSource = this.stani_bogatDataSet;
            this.stanibogatDataSetBindingSource.Position = 0;
            // 
            // questionsBindingSource
            // 
            this.questionsBindingSource.DataMember = "Questions";
            this.questionsBindingSource.DataSource = this.stani_bogatDataSet;
            // 
            // questionsTableAdapter
            // 
            this.questionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.QuestionsTableAdapter = this.questionsTableAdapter;
            this.tableAdapterManager.UpdateOrder = StaniBogat1.stani_bogatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // questionTextBox
            // 
            this.questionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "Question", true));
            this.questionTextBox.Location = new System.Drawing.Point(159, 45);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(217, 22);
            this.questionTextBox.TabIndex = 1;
            // 
            // ans1TextBox
            // 
            this.ans1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "ans1", true));
            this.ans1TextBox.Location = new System.Drawing.Point(159, 75);
            this.ans1TextBox.Name = "ans1TextBox";
            this.ans1TextBox.Size = new System.Drawing.Size(217, 22);
            this.ans1TextBox.TabIndex = 3;
            // 
            // ans2TextBox
            // 
            this.ans2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "ans2", true));
            this.ans2TextBox.Location = new System.Drawing.Point(159, 103);
            this.ans2TextBox.Name = "ans2TextBox";
            this.ans2TextBox.Size = new System.Drawing.Size(217, 22);
            this.ans2TextBox.TabIndex = 5;
            // 
            // ans3TextBox
            // 
            this.ans3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "ans3", true));
            this.ans3TextBox.Location = new System.Drawing.Point(159, 135);
            this.ans3TextBox.Name = "ans3TextBox";
            this.ans3TextBox.Size = new System.Drawing.Size(217, 22);
            this.ans3TextBox.TabIndex = 7;
            // 
            // ans4TextBox
            // 
            this.ans4TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "ans4", true));
            this.ans4TextBox.Location = new System.Drawing.Point(159, 169);
            this.ans4TextBox.Name = "ans4TextBox";
            this.ans4TextBox.Size = new System.Drawing.Size(217, 22);
            this.ans4TextBox.TabIndex = 9;
            // 
            // correctTextBox
            // 
            this.correctTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "correct", true));
            this.correctTextBox.Location = new System.Drawing.Point(159, 197);
            this.correctTextBox.Name = "correctTextBox";
            this.correctTextBox.Size = new System.Drawing.Size(217, 22);
            this.correctTextBox.TabIndex = 11;
            // 
            // pointsTextBox
            // 
            this.pointsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "points", true));
            this.pointsTextBox.Location = new System.Drawing.Point(159, 226);
            this.pointsTextBox.Name = "pointsTextBox";
            this.pointsTextBox.Size = new System.Drawing.Size(217, 22);
            this.pointsTextBox.TabIndex = 13;
            // 
            // questionsDataGridView
            // 
            this.questionsDataGridView.AutoGenerateColumns = false;
            this.questionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.questionsDataGridView.DataSource = this.questionsBindingSource;
            this.questionsDataGridView.Location = new System.Drawing.Point(461, 12);
            this.questionsDataGridView.Name = "questionsDataGridView";
            this.questionsDataGridView.RowHeadersWidth = 51;
            this.questionsDataGridView.RowTemplate.Height = 24;
            this.questionsDataGridView.Size = new System.Drawing.Size(551, 220);
            this.questionsDataGridView.TabIndex = 14;
            this.questionsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.questionsDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Question";
            this.dataGridViewTextBoxColumn2.HeaderText = "Question";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ans1";
            this.dataGridViewTextBoxColumn3.HeaderText = "ans1";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ans2";
            this.dataGridViewTextBoxColumn4.HeaderText = "ans2";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ans3";
            this.dataGridViewTextBoxColumn5.HeaderText = "ans3";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ans4";
            this.dataGridViewTextBoxColumn6.HeaderText = "ans4";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "correct";
            this.dataGridViewTextBoxColumn7.HeaderText = "correct";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "points";
            this.dataGridViewTextBoxColumn8.HeaderText = "points";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // btnBackToGame
            // 
            this.btnBackToGame.Location = new System.Drawing.Point(436, 328);
            this.btnBackToGame.Name = "btnBackToGame";
            this.btnBackToGame.Size = new System.Drawing.Size(160, 23);
            this.btnBackToGame.TabIndex = 15;
            this.btnBackToGame.Text = "Обратно към играта";
            this.btnBackToGame.UseVisualStyleBackColor = true;
            this.btnBackToGame.Click += new System.EventHandler(this.btnBackToGame_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 428);
            this.Controls.Add(this.btnBackToGame);
            this.Controls.Add(this.questionsDataGridView);
            this.Controls.Add(pointsLabel);
            this.Controls.Add(this.pointsTextBox);
            this.Controls.Add(correctLabel);
            this.Controls.Add(this.correctTextBox);
            this.Controls.Add(ans4Label);
            this.Controls.Add(this.ans4TextBox);
            this.Controls.Add(ans3Label);
            this.Controls.Add(this.ans3TextBox);
            this.Controls.Add(ans2Label);
            this.Controls.Add(this.ans2TextBox);
            this.Controls.Add(ans1Label);
            this.Controls.Add(this.ans1TextBox);
            this.Controls.Add(questionLabel);
            this.Controls.Add(this.questionTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Админ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stani_bogatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanibogatDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private stani_bogatDataSet stani_bogatDataSet;
        private System.Windows.Forms.BindingSource stanibogatDataSetBindingSource;
        private System.Windows.Forms.BindingSource questionsBindingSource;
        private stani_bogatDataSetTableAdapters.QuestionsTableAdapter questionsTableAdapter;
        private stani_bogatDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.TextBox ans1TextBox;
        private System.Windows.Forms.TextBox ans2TextBox;
        private System.Windows.Forms.TextBox ans3TextBox;
        private System.Windows.Forms.TextBox ans4TextBox;
        private System.Windows.Forms.TextBox correctTextBox;
        private System.Windows.Forms.TextBox pointsTextBox;
        private System.Windows.Forms.DataGridView questionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btnBackToGame;
    }
}