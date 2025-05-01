namespace StaniBogat1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblAns1 = new System.Windows.Forms.Label();
            this.lblAns2 = new System.Windows.Forms.Label();
            this.lblAns3 = new System.Windows.Forms.Label();
            this.lblAns4 = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.stani_bogatDataSet1 = new StaniBogat1.stani_bogatDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.stani_bogatDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.Snow;
            this.lblQuestion.Location = new System.Drawing.Point(92, 203);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(591, 25);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // lblAns1
            // 
            this.lblAns1.BackColor = System.Drawing.Color.Transparent;
            this.lblAns1.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAns1.ForeColor = System.Drawing.Color.Snow;
            this.lblAns1.Location = new System.Drawing.Point(96, 259);
            this.lblAns1.Name = "lblAns1";
            this.lblAns1.Size = new System.Drawing.Size(249, 39);
            this.lblAns1.TabIndex = 1;
            this.lblAns1.Text = "Answer1";
            this.lblAns1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAns1.Click += new System.EventHandler(this.lblAnswer1_Click);
            // 
            // lblAns2
            // 
            this.lblAns2.BackColor = System.Drawing.Color.Transparent;
            this.lblAns2.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAns2.ForeColor = System.Drawing.Color.Snow;
            this.lblAns2.Location = new System.Drawing.Point(425, 259);
            this.lblAns2.Name = "lblAns2";
            this.lblAns2.Size = new System.Drawing.Size(261, 39);
            this.lblAns2.TabIndex = 2;
            this.lblAns2.Text = "Answer2";
            this.lblAns2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAns2.Click += new System.EventHandler(this.lblAnswer2_Click);
            // 
            // lblAns3
            // 
            this.lblAns3.BackColor = System.Drawing.Color.Transparent;
            this.lblAns3.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAns3.ForeColor = System.Drawing.Color.Snow;
            this.lblAns3.Location = new System.Drawing.Point(93, 322);
            this.lblAns3.Name = "lblAns3";
            this.lblAns3.Size = new System.Drawing.Size(252, 39);
            this.lblAns3.TabIndex = 3;
            this.lblAns3.Text = "Answer3";
            this.lblAns3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAns3.Click += new System.EventHandler(this.lblAnswer3_Click);
            // 
            // lblAns4
            // 
            this.lblAns4.BackColor = System.Drawing.Color.Transparent;
            this.lblAns4.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAns4.ForeColor = System.Drawing.Color.Snow;
            this.lblAns4.Location = new System.Drawing.Point(425, 322);
            this.lblAns4.Name = "lblAns4";
            this.lblAns4.Size = new System.Drawing.Size(261, 39);
            this.lblAns4.TabIndex = 4;
            this.lblAns4.Text = "Answer4";
            this.lblAns4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAns4.Click += new System.EventHandler(this.lblAnswer4_Click);
            // 
            // lblPoints
            // 
            this.lblPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblPoints.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPoints.ForeColor = System.Drawing.Color.Snow;
            this.lblPoints.Location = new System.Drawing.Point(629, 20);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(132, 16);
            this.lblPoints.TabIndex = 5;
            this.lblPoints.Text = "Points:";
            this.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPoints.Click += new System.EventHandler(this.lblPoints_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmin.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(13, 13);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // stani_bogatDataSet1
            // 
            this.stani_bogatDataSet1.DataSetName = "stani_bogatDataSet";
            this.stani_bogatDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StaniBogat1.Properties.Resources.staniBogat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 440);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblAns4);
            this.Controls.Add(this.lblAns3);
            this.Controls.Add(this.lblAns2);
            this.Controls.Add(this.lblAns1);
            this.Controls.Add(this.lblQuestion);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Стани богат";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stani_bogatDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblAns1;
        private System.Windows.Forms.Label lblAns2;
        private System.Windows.Forms.Label lblAns3;
        private System.Windows.Forms.Label lblAns4;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Button btnAdmin;
        private stani_bogatDataSet stani_bogatDataSet1;
    }
}

