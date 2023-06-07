namespace NosovDiplom
{
    partial class EnterForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            TurnoverInput = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            ProfitInput = new TextBox();
            textBox7 = new TextBox();
            ExitButton = new Button();
            Next = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(492, 46);
            label1.TabIndex = 0;
            label1.Text = "Введите значения основных показателей хозяйственной\r\nдеятельности за отчётный год";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(83, 87);
            label2.Name = "label2";
            label2.Size = new Size(98, 17);
            label2.TabIndex = 1;
            label2.Text = "Товарооборот";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(83, 116);
            label3.Name = "label3";
            label3.Size = new Size(148, 17);
            label3.TabIndex = 2;
            label3.Text = "Издержки обращения";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(83, 145);
            label4.Name = "label4";
            label4.Size = new Size(200, 17);
            label4.TabIndex = 3;
            label4.Text = "Расходы на заработную плату";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(83, 173);
            label5.Name = "label5";
            label5.Size = new Size(119, 17);
            label5.TabIndex = 4;
            label5.Text = "Основные фонды";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(83, 202);
            label6.Name = "label6";
            label6.Size = new Size(140, 17);
            label6.TabIndex = 5;
            label6.Text = "Оборотные средства";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(83, 229);
            label7.Name = "label7";
            label7.Size = new Size(66, 17);
            label7.TabIndex = 6;
            label7.Text = "Прибыль";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(83, 258);
            label8.Name = "label8";
            label8.Size = new Size(104, 17);
            label8.TabIndex = 7;
            label8.Text = "Число рабочих";
            // 
            // TurnoverInput
            // 
            TurnoverInput.Location = new Point(287, 81);
            TurnoverInput.Name = "TurnoverInput";
            TurnoverInput.Size = new Size(160, 23);
            TurnoverInput.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(287, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(287, 139);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(160, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(287, 173);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(160, 23);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(287, 202);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(160, 23);
            textBox5.TabIndex = 12;
            // 
            // ProfitInput
            // 
            ProfitInput.Location = new Point(287, 229);
            ProfitInput.Name = "ProfitInput";
            ProfitInput.Size = new Size(160, 23);
            ProfitInput.TabIndex = 13;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(287, 258);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(160, 23);
            textBox7.TabIndex = 14;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(723, 469);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(131, 39);
            ExitButton.TabIndex = 15;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // Next
            // 
            Next.Location = new Point(22, 469);
            Next.Name = "Next";
            Next.Size = new Size(131, 39);
            Next.TabIndex = 16;
            Next.Text = "Далее";
            Next.UseVisualStyleBackColor = true;
            Next.Click += Next_Click;
            // 
            // EnterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 520);
            Controls.Add(Next);
            Controls.Add(ExitButton);
            Controls.Add(textBox7);
            Controls.Add(ProfitInput);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(TurnoverInput);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EnterForm";
            Text = "Система расчёта хоз. деятельности мероприятия";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox TurnoverInput;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox ProfitInput;
        private TextBox textBox7;
        private Button ExitButton;
        private Button Next;
    }
}