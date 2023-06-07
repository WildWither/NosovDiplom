namespace NosovDiplom
{
    partial class OutputForm
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
            label1 = new Label();
            TradeTurnoverResultBox = new TextBox();
            label2 = new Label();
            ContactWaitBox = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 91);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Товарооборот";
            label1.Click += label1_Click;
            // 
            // TradeTurnoverResultBox
            // 
            TradeTurnoverResultBox.Location = new Point(286, 88);
            TradeTurnoverResultBox.Name = "TradeTurnoverResultBox";
            TradeTurnoverResultBox.ReadOnly = true;
            TradeTurnoverResultBox.Size = new Size(154, 23);
            TradeTurnoverResultBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 9);
            label2.Name = "label2";
            label2.Size = new Size(628, 50);
            label2.TabIndex = 2;
            label2.Text = "Темпы прироста основных показателей хозяйственной деятельности\r\nза анализируемый период\r\n";
            // 
            // ContactWaitBox
            // 
            ContactWaitBox.Location = new Point(286, 117);
            ContactWaitBox.Name = "ContactWaitBox";
            ContactWaitBox.ReadOnly = true;
            ContactWaitBox.Size = new Size(154, 23);
            ContactWaitBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 120);
            label3.Name = "label3";
            label3.Size = new Size(164, 20);
            label3.TabIndex = 3;
            label3.Text = "Издержки обращения";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(286, 146);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(154, 23);
            textBox2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(29, 149);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 5;
            label4.Text = "Расходы на ЗП";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(286, 175);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(154, 23);
            textBox3.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(29, 178);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 7;
            label5.Text = "Основные фонды";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(286, 204);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(154, 23);
            textBox4.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(29, 207);
            label6.Name = "label6";
            label6.Size = new Size(155, 20);
            label6.TabIndex = 9;
            label6.Text = "Оборотные средства";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(286, 233);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(154, 23);
            textBox5.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(29, 236);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 11;
            label7.Text = "Прибыль";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(286, 262);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(154, 23);
            textBox6.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(29, 265);
            label8.Name = "label8";
            label8.Size = new Size(162, 20);
            label8.TabIndex = 13;
            label8.Text = "Численность рабочих";
            // 
            // OutputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(ContactWaitBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TradeTurnoverResultBox);
            Controls.Add(label1);
            Name = "OutputForm";
            Text = "Результаты вычислений";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TradeTurnoverResultBox;
        private Label label2;
        private TextBox ContactWaitBox;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
    }
}