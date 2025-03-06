namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            OwnerTxt = new TextBox();
            Amounttxt = new NumericUpDown();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            DepositeBtn = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)Amounttxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 34);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 38);
            label1.TabIndex = 0;
            label1.Text = "Owner";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 429);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 38);
            label2.TabIndex = 1;
            label2.Text = "Amount";
            // 
            // OwnerTxt
            // 
            OwnerTxt.Location = new Point(248, 34);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(250, 43);
            OwnerTxt.TabIndex = 2;
            // 
            // Amounttxt
            // 
            Amounttxt.Location = new Point(275, 427);
            Amounttxt.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            Amounttxt.Name = "Amounttxt";
            Amounttxt.Size = new Size(234, 43);
            Amounttxt.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(645, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(711, 329);
            dataGridView1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(645, 386);
            button1.Name = "button1";
            button1.Size = new Size(353, 92);
            button1.TabIndex = 5;
            button1.Text = "withdrawl";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DepositeBtn
            // 
            DepositeBtn.Location = new Point(1031, 386);
            DepositeBtn.Name = "DepositeBtn";
            DepositeBtn.Size = new Size(325, 92);
            DepositeBtn.TabIndex = 6;
            DepositeBtn.Text = "Deposite";
            DepositeBtn.UseVisualStyleBackColor = true;
            DepositeBtn.Click += DepositeBtn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(187, 181);
            button3.Name = "button3";
            button3.Size = new Size(311, 42);
            button3.TabIndex = 7;
            button3.Text = "Create Account";
            button3.UseVisualStyleBackColor = true;
            button3.Click += CreateAccountbtn;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 832);
            Controls.Add(button3);
            Controls.Add(DepositeBtn);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(Amounttxt);
            Controls.Add(OwnerTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Amounttxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox OwnerTxt;
        private NumericUpDown Amounttxt;
        private DataGridView dataGridView1;
        private Button button1;
        private Button DepositeBtn;
        private Button button3;
    }
}
