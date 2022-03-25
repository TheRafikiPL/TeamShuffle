
namespace TeamShuffle
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_team1 = new System.Windows.Forms.Label();
            this.team1_player1 = new System.Windows.Forms.TextBox();
            this.team1_player2 = new System.Windows.Forms.TextBox();
            this.team1_player3 = new System.Windows.Forms.TextBox();
            this.team1_player4 = new System.Windows.Forms.TextBox();
            this.team1_player5 = new System.Windows.Forms.TextBox();
            this.label_team2 = new System.Windows.Forms.Label();
            this.team2_player1 = new System.Windows.Forms.TextBox();
            this.team2_player2 = new System.Windows.Forms.TextBox();
            this.team2_player3 = new System.Windows.Forms.TextBox();
            this.team2_player4 = new System.Windows.Forms.TextBox();
            this.team2_player5 = new System.Windows.Forms.TextBox();
            this.vs = new System.Windows.Forms.Label();
            this.shuffle_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.load_button = new System.Windows.Forms.Button();
            this.loadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label_team1
            // 
            this.label_team1.AutoSize = true;
            this.label_team1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_team1.Location = new System.Drawing.Point(13, 13);
            this.label_team1.Name = "label_team1";
            this.label_team1.Size = new System.Drawing.Size(78, 25);
            this.label_team1.TabIndex = 0;
            this.label_team1.Text = "Team1";
            // 
            // team1_player1
            // 
            this.team1_player1.Location = new System.Drawing.Point(18, 53);
            this.team1_player1.Name = "team1_player1";
            this.team1_player1.Size = new System.Drawing.Size(130, 23);
            this.team1_player1.TabIndex = 1;
            // 
            // team1_player2
            // 
            this.team1_player2.Location = new System.Drawing.Point(18, 103);
            this.team1_player2.Name = "team1_player2";
            this.team1_player2.Size = new System.Drawing.Size(130, 23);
            this.team1_player2.TabIndex = 2;
            // 
            // team1_player3
            // 
            this.team1_player3.Location = new System.Drawing.Point(18, 153);
            this.team1_player3.Name = "team1_player3";
            this.team1_player3.Size = new System.Drawing.Size(130, 23);
            this.team1_player3.TabIndex = 3;
            // 
            // team1_player4
            // 
            this.team1_player4.Location = new System.Drawing.Point(18, 203);
            this.team1_player4.Name = "team1_player4";
            this.team1_player4.Size = new System.Drawing.Size(130, 23);
            this.team1_player4.TabIndex = 4;
            // 
            // team1_player5
            // 
            this.team1_player5.Location = new System.Drawing.Point(18, 253);
            this.team1_player5.Name = "team1_player5";
            this.team1_player5.Size = new System.Drawing.Size(130, 23);
            this.team1_player5.TabIndex = 5;
            // 
            // label_team2
            // 
            this.label_team2.AutoSize = true;
            this.label_team2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_team2.Location = new System.Drawing.Point(709, 13);
            this.label_team2.Name = "label_team2";
            this.label_team2.Size = new System.Drawing.Size(78, 25);
            this.label_team2.TabIndex = 6;
            this.label_team2.Text = "Team2";
            // 
            // team2_player1
            // 
            this.team2_player1.Location = new System.Drawing.Point(658, 53);
            this.team2_player1.Name = "team2_player1";
            this.team2_player1.Size = new System.Drawing.Size(130, 23);
            this.team2_player1.TabIndex = 7;
            // 
            // team2_player2
            // 
            this.team2_player2.Location = new System.Drawing.Point(658, 103);
            this.team2_player2.Name = "team2_player2";
            this.team2_player2.Size = new System.Drawing.Size(130, 23);
            this.team2_player2.TabIndex = 8;
            // 
            // team2_player3
            // 
            this.team2_player3.Location = new System.Drawing.Point(658, 153);
            this.team2_player3.Name = "team2_player3";
            this.team2_player3.Size = new System.Drawing.Size(130, 23);
            this.team2_player3.TabIndex = 9;
            // 
            // team2_player4
            // 
            this.team2_player4.Location = new System.Drawing.Point(658, 203);
            this.team2_player4.Name = "team2_player4";
            this.team2_player4.Size = new System.Drawing.Size(130, 23);
            this.team2_player4.TabIndex = 10;
            // 
            // team2_player5
            // 
            this.team2_player5.Location = new System.Drawing.Point(658, 253);
            this.team2_player5.Name = "team2_player5";
            this.team2_player5.Size = new System.Drawing.Size(130, 23);
            this.team2_player5.TabIndex = 11;
            // 
            // vs
            // 
            this.vs.AutoSize = true;
            this.vs.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vs.Location = new System.Drawing.Point(320, 118);
            this.vs.Margin = new System.Windows.Forms.Padding(0);
            this.vs.Name = "vs";
            this.vs.Size = new System.Drawing.Size(173, 108);
            this.vs.TabIndex = 12;
            this.vs.Text = "VS";
            // 
            // shuffle_button
            // 
            this.shuffle_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shuffle_button.Location = new System.Drawing.Point(320, 344);
            this.shuffle_button.Name = "shuffle_button";
            this.shuffle_button.Size = new System.Drawing.Size(173, 44);
            this.shuffle_button.TabIndex = 13;
            this.shuffle_button.Text = "Shuffle";
            this.shuffle_button.UseVisualStyleBackColor = true;
            this.shuffle_button.Click += new System.EventHandler(this.shuffle_button_Click);
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.save_button.Location = new System.Drawing.Point(658, 344);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(129, 44);
            this.save_button.TabIndex = 14;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // load_button
            // 
            this.load_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.load_button.Location = new System.Drawing.Point(19, 344);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(129, 44);
            this.load_button.TabIndex = 15;
            this.load_button.Text = "Load";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // loadFileDialog
            // 
            this.loadFileDialog.FileName = "openFileDialog1";
            this.loadFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.shuffle_button);
            this.Controls.Add(this.vs);
            this.Controls.Add(this.team2_player5);
            this.Controls.Add(this.team2_player4);
            this.Controls.Add(this.team2_player3);
            this.Controls.Add(this.team2_player2);
            this.Controls.Add(this.team2_player1);
            this.Controls.Add(this.label_team2);
            this.Controls.Add(this.team1_player5);
            this.Controls.Add(this.team1_player4);
            this.Controls.Add(this.team1_player3);
            this.Controls.Add(this.team1_player2);
            this.Controls.Add(this.team1_player1);
            this.Controls.Add(this.label_team1);
            this.Name = "Form1";
            this.Text = "Team Shuffle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_team1;
        private System.Windows.Forms.TextBox team1_player1;
        private System.Windows.Forms.TextBox team1_player2;
        private System.Windows.Forms.TextBox team1_player3;
        private System.Windows.Forms.TextBox team1_player4;
        private System.Windows.Forms.TextBox team1_player5;
        private System.Windows.Forms.Label label_team2;
        private System.Windows.Forms.TextBox team2_player1;
        private System.Windows.Forms.TextBox team2_player2;
        private System.Windows.Forms.TextBox team2_player3;
        private System.Windows.Forms.TextBox team2_player4;
        private System.Windows.Forms.TextBox team2_player5;
        private System.Windows.Forms.Label vs;
        private System.Windows.Forms.Button shuffle_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.OpenFileDialog loadFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

