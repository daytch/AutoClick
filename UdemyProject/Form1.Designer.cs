namespace UdemyProject
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WebTarget = new System.Windows.Forms.Label();
            this.WebTargetInput = new System.Windows.Forms.TextBox();
            this.ID2 = new System.Windows.Forms.Label();
            this.ID2Input = new System.Windows.Forms.TextBox();
            this.RangeID2 = new System.Windows.Forms.Label();
            this.RangeID2Start = new System.Windows.Forms.TextBox();
            this.RangeID2End = new System.Windows.Forms.TextBox();
            this.Looping = new System.Windows.Forms.Label();
            this.LoopingInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMsgID2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorLooping = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMsgID2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLooping)).BeginInit();
            this.SuspendLayout();
            // 
            // WebTarget
            // 
            this.WebTarget.AutoSize = true;
            this.WebTarget.Location = new System.Drawing.Point(31, 35);
            this.WebTarget.Name = "WebTarget";
            this.WebTarget.Size = new System.Drawing.Size(64, 13);
            this.WebTarget.TabIndex = 0;
            this.WebTarget.Text = "Web Target";
            // 
            // WebTargetInput
            // 
            this.WebTargetInput.Location = new System.Drawing.Point(145, 27);
            this.WebTargetInput.Name = "WebTargetInput";
            this.WebTargetInput.Size = new System.Drawing.Size(386, 20);
            this.WebTargetInput.TabIndex = 1;
            this.WebTargetInput.Validating += new System.ComponentModel.CancelEventHandler(this.ValidationWebTargetInput);
            // 
            // ID2
            // 
            this.ID2.AutoSize = true;
            this.ID2.Location = new System.Drawing.Point(31, 79);
            this.ID2.Name = "ID2";
            this.ID2.Size = new System.Drawing.Size(73, 13);
            this.ID2.TabIndex = 2;
            this.ID2.Text = "ID2 Sekarang";
            // 
            // ID2Input
            // 
            this.ID2Input.Location = new System.Drawing.Point(145, 72);
            this.ID2Input.Name = "ID2Input";
            this.ID2Input.Size = new System.Drawing.Size(386, 20);
            this.ID2Input.TabIndex = 3;
            this.ID2Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidationNumber);
            this.ID2Input.Validating += new System.ComponentModel.CancelEventHandler(this.ValidationID2);
            // 
            // RangeID2
            // 
            this.RangeID2.AutoSize = true;
            this.RangeID2.Location = new System.Drawing.Point(31, 122);
            this.RangeID2.Name = "RangeID2";
            this.RangeID2.Size = new System.Drawing.Size(59, 13);
            this.RangeID2.TabIndex = 4;
            this.RangeID2.Text = "Range ID2";
            // 
            // RangeID2Start
            // 
            this.RangeID2Start.Location = new System.Drawing.Point(145, 114);
            this.RangeID2Start.Name = "RangeID2Start";
            this.RangeID2Start.Size = new System.Drawing.Size(174, 20);
            this.RangeID2Start.TabIndex = 5;
            this.RangeID2Start.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidationNumber);
            // 
            // RangeID2End
            // 
            this.RangeID2End.Location = new System.Drawing.Point(345, 113);
            this.RangeID2End.Name = "RangeID2End";
            this.RangeID2End.Size = new System.Drawing.Size(186, 20);
            this.RangeID2End.TabIndex = 6;
            this.RangeID2End.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidationNumber);
            // 
            // Looping
            // 
            this.Looping.AutoSize = true;
            this.Looping.Location = new System.Drawing.Point(34, 171);
            this.Looping.Name = "Looping";
            this.Looping.Size = new System.Drawing.Size(45, 13);
            this.Looping.TabIndex = 7;
            this.Looping.Text = "Looping";
            // 
            // LoopingInput
            // 
            this.LoopingInput.Location = new System.Drawing.Point(145, 163);
            this.LoopingInput.Name = "LoopingInput";
            this.LoopingInput.Size = new System.Drawing.Size(174, 20);
            this.LoopingInput.TabIndex = 8;
            this.LoopingInput.Validating += new System.ComponentModel.CancelEventHandler(this.ValidationLooping);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Menit";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(345, 279);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(456, 279);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorMsgID2
            // 
            this.errorMsgID2.ContainerControl = this;
            // 
            // errorLooping
            // 
            this.errorLooping.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 332);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoopingInput);
            this.Controls.Add(this.Looping);
            this.Controls.Add(this.RangeID2End);
            this.Controls.Add(this.RangeID2Start);
            this.Controls.Add(this.RangeID2);
            this.Controls.Add(this.ID2Input);
            this.Controls.Add(this.ID2);
            this.Controls.Add(this.WebTargetInput);
            this.Controls.Add(this.WebTarget);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form Scheduler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMsgID2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLooping)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WebTarget;
        private System.Windows.Forms.TextBox WebTargetInput;
        private System.Windows.Forms.Label ID2;
        private System.Windows.Forms.TextBox ID2Input;
        private System.Windows.Forms.Label RangeID2;
        private System.Windows.Forms.TextBox RangeID2Start;
        private System.Windows.Forms.TextBox RangeID2End;
        private System.Windows.Forms.Label Looping;
        private System.Windows.Forms.TextBox LoopingInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorMsgID2;
        private System.Windows.Forms.ErrorProvider errorLooping;
    }
}

