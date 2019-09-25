namespace SortingApp
{
    partial class sortingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sortingForm));
            this.listDisplay = new System.Windows.Forms.TextBox();
            this.newListButton = new System.Windows.Forms.Button();
            this.bubbleSortButton = new System.Windows.Forms.Button();
            this.currentOperationLabel = new System.Windows.Forms.Label();
            this.selectionSortButton = new System.Windows.Forms.Button();
            this.mergeSortButton = new System.Windows.Forms.Button();
            this.quickSortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listDisplay
            // 
            this.listDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDisplay.Location = new System.Drawing.Point(12, 37);
            this.listDisplay.Name = "listDisplay";
            this.listDisplay.Size = new System.Drawing.Size(523, 30);
            this.listDisplay.TabIndex = 0;
            this.listDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newListButton
            // 
            this.newListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newListButton.Location = new System.Drawing.Point(205, 73);
            this.newListButton.Name = "newListButton";
            this.newListButton.Size = new System.Drawing.Size(124, 30);
            this.newListButton.TabIndex = 1;
            this.newListButton.Text = "New List";
            this.newListButton.UseVisualStyleBackColor = true;
            this.newListButton.Click += new System.EventHandler(this.NewListClick);
            // 
            // bubbleSortButton
            // 
            this.bubbleSortButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bubbleSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bubbleSortButton.Location = new System.Drawing.Point(76, 121);
            this.bubbleSortButton.Name = "bubbleSortButton";
            this.bubbleSortButton.Size = new System.Drawing.Size(131, 39);
            this.bubbleSortButton.TabIndex = 2;
            this.bubbleSortButton.Text = "Bubble";
            this.bubbleSortButton.UseVisualStyleBackColor = false;
            this.bubbleSortButton.Click += new System.EventHandler(this.BubbleSortButtonClick);
            // 
            // currentOperationLabel
            // 
            this.currentOperationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentOperationLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.currentOperationLabel.Location = new System.Drawing.Point(12, 9);
            this.currentOperationLabel.Name = "currentOperationLabel";
            this.currentOperationLabel.Size = new System.Drawing.Size(523, 25);
            this.currentOperationLabel.TabIndex = 3;
            this.currentOperationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectionSortButton
            // 
            this.selectionSortButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.selectionSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionSortButton.Location = new System.Drawing.Point(328, 121);
            this.selectionSortButton.Name = "selectionSortButton";
            this.selectionSortButton.Size = new System.Drawing.Size(131, 39);
            this.selectionSortButton.TabIndex = 4;
            this.selectionSortButton.Text = "Selection";
            this.selectionSortButton.UseVisualStyleBackColor = false;
            this.selectionSortButton.Click += new System.EventHandler(this.SelectionSortButtonClick);
            // 
            // mergeSortButton
            // 
            this.mergeSortButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.mergeSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mergeSortButton.Location = new System.Drawing.Point(76, 175);
            this.mergeSortButton.Name = "mergeSortButton";
            this.mergeSortButton.Size = new System.Drawing.Size(131, 39);
            this.mergeSortButton.TabIndex = 5;
            this.mergeSortButton.Text = "Merge";
            this.mergeSortButton.UseVisualStyleBackColor = false;
            // 
            // quickSortButton
            // 
            this.quickSortButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.quickSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickSortButton.Location = new System.Drawing.Point(328, 175);
            this.quickSortButton.Name = "quickSortButton";
            this.quickSortButton.Size = new System.Drawing.Size(131, 39);
            this.quickSortButton.TabIndex = 6;
            this.quickSortButton.Text = "Quick";
            this.quickSortButton.UseVisualStyleBackColor = false;
            // 
            // sortingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 233);
            this.Controls.Add(this.quickSortButton);
            this.Controls.Add(this.mergeSortButton);
            this.Controls.Add(this.selectionSortButton);
            this.Controls.Add(this.currentOperationLabel);
            this.Controls.Add(this.bubbleSortButton);
            this.Controls.Add(this.newListButton);
            this.Controls.Add(this.listDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "sortingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorting App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox listDisplay;
        private System.Windows.Forms.Button newListButton;
        private System.Windows.Forms.Button bubbleSortButton;
        private System.Windows.Forms.Label currentOperationLabel;
        private System.Windows.Forms.Button selectionSortButton;
        private System.Windows.Forms.Button mergeSortButton;
        private System.Windows.Forms.Button quickSortButton;
    }
}

