namespace CookTable
{
    partial class Cooker
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
            this.offeredmeals = new System.Windows.Forms.DataGridView();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.UpdateProgress = new System.Windows.Forms.ProgressBar();
            this.UpdateBarLabel = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubOfferID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MealId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MealName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MealCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MealWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeSpent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reciepe = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CookStart = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OfferIdHidden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OfferedMealIdHidden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgressTimer = new System.Windows.Forms.Timer(this.components);
            this.TimeLabel = new System.Windows.Forms.Label();
            this.ForceUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.offeredmeals)).BeginInit();
            this.SuspendLayout();
            // 
            // offeredmeals
            // 
            this.offeredmeals.AllowUserToAddRows = false;
            this.offeredmeals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.offeredmeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.offeredmeals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SubOfferID,
            this.MealId,
            this.MealName,
            this.MealCount,
            this.MealWeight,
            this.Start,
            this.Comment,
            this.TimeSpent,
            this.Reciepe,
            this.CookStart,
            this.State,
            this.OfferIdHidden,
            this.OfferedMealIdHidden});
            this.offeredmeals.Location = new System.Drawing.Point(14, 12);
            this.offeredmeals.Margin = new System.Windows.Forms.Padding(0);
            this.offeredmeals.Name = "offeredmeals";
            this.offeredmeals.RowHeadersVisible = false;
            this.offeredmeals.RowTemplate.Height = 40;
            this.offeredmeals.Size = new System.Drawing.Size(1400, 670);
            this.offeredmeals.TabIndex = 0;
            this.offeredmeals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.offeredmeals_CellContentClick);
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Interval = 60000;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // UpdateProgress
            // 
            this.UpdateProgress.Location = new System.Drawing.Point(169, 686);
            this.UpdateProgress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateProgress.Name = "UpdateProgress";
            this.UpdateProgress.Size = new System.Drawing.Size(770, 68);
            this.UpdateProgress.TabIndex = 1;
            // 
            // UpdateBarLabel
            // 
            this.UpdateBarLabel.AutoSize = true;
            this.UpdateBarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateBarLabel.Location = new System.Drawing.Point(13, 707);
            this.UpdateBarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpdateBarLabel.Name = "UpdateBarLabel";
            this.UpdateBarLabel.Size = new System.Drawing.Size(148, 24);
            this.UpdateBarLabel.TabIndex = 2;
            this.UpdateBarLabel.Text = "До обновления";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID заказа";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 70;
            // 
            // SubOfferID
            // 
            this.SubOfferID.HeaderText = "ID позиции";
            this.SubOfferID.Name = "SubOfferID";
            this.SubOfferID.ReadOnly = true;
            this.SubOfferID.Width = 70;
            // 
            // MealId
            // 
            this.MealId.HeaderText = "ID блюда";
            this.MealId.Name = "MealId";
            this.MealId.ReadOnly = true;
            this.MealId.Width = 70;
            // 
            // MealName
            // 
            this.MealName.HeaderText = "Блюдо";
            this.MealName.Name = "MealName";
            this.MealName.ReadOnly = true;
            this.MealName.Width = 150;
            // 
            // MealCount
            // 
            this.MealCount.HeaderText = "Кол-во";
            this.MealCount.Name = "MealCount";
            this.MealCount.ReadOnly = true;
            this.MealCount.Width = 70;
            // 
            // MealWeight
            // 
            this.MealWeight.HeaderText = "Вес блюда";
            this.MealWeight.Name = "MealWeight";
            this.MealWeight.ReadOnly = true;
            this.MealWeight.Width = 70;
            // 
            // Start
            // 
            this.Start.HeaderText = "Время заказа";
            this.Start.Name = "Start";
            this.Start.ReadOnly = true;
            this.Start.Width = 200;
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Комментарий";
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            this.Comment.Width = 200;
            // 
            // TimeSpent
            // 
            this.TimeSpent.HeaderText = "Минут прошло";
            this.TimeSpent.Name = "TimeSpent";
            // 
            // Reciepe
            // 
            this.Reciepe.HeaderText = "Рецепт";
            this.Reciepe.Name = "Reciepe";
            this.Reciepe.ReadOnly = true;
            this.Reciepe.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Reciepe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Reciepe.Width = 150;
            // 
            // CookStart
            // 
            this.CookStart.HeaderText = "Начало готовки";
            this.CookStart.Name = "CookStart";
            this.CookStart.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CookStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CookStart.Width = 120;
            // 
            // State
            // 
            this.State.HeaderText = "Готовность";
            this.State.Name = "State";
            this.State.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.State.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.State.Width = 120;
            // 
            // OfferIdHidden
            // 
            this.OfferIdHidden.HeaderText = "Заказ";
            this.OfferIdHidden.Name = "OfferIdHidden";
            this.OfferIdHidden.ReadOnly = true;
            this.OfferIdHidden.Visible = false;
            // 
            // OfferedMealIdHidden
            // 
            this.OfferedMealIdHidden.HeaderText = "Позиция";
            this.OfferedMealIdHidden.Name = "OfferedMealIdHidden";
            this.OfferedMealIdHidden.ReadOnly = true;
            this.OfferedMealIdHidden.Visible = false;
            // 
            // ProgressTimer
            // 
            this.ProgressTimer.Interval = 1000;
            this.ProgressTimer.Tick += new System.EventHandler(this.ProgressTimer_Tick);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLabel.Location = new System.Drawing.Point(540, 707);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(30, 24);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "60";
            // 
            // ForceUpdate
            // 
            this.ForceUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForceUpdate.Location = new System.Drawing.Point(946, 686);
            this.ForceUpdate.Name = "ForceUpdate";
            this.ForceUpdate.Size = new System.Drawing.Size(465, 68);
            this.ForceUpdate.TabIndex = 4;
            this.ForceUpdate.Text = "Принудительное обновление";
            this.ForceUpdate.UseVisualStyleBackColor = true;
            this.ForceUpdate.Click += new System.EventHandler(this.ForceUpdate_Click);
            // 
            // Cooker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 767);
            this.Controls.Add(this.ForceUpdate);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.UpdateBarLabel);
            this.Controls.Add(this.UpdateProgress);
            this.Controls.Add(this.offeredmeals);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Cooker";
            this.Text = "CookTable";
            this.Load += new System.EventHandler(this.Cooker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.offeredmeals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView offeredmeals;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubOfferID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MealId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MealName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MealCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn MealWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeSpent;
        private System.Windows.Forms.DataGridViewButtonColumn Reciepe;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CookStart;
        private System.Windows.Forms.DataGridViewCheckBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfferIdHidden;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfferedMealIdHidden;
        private System.Windows.Forms.ProgressBar UpdateProgress;
        private System.Windows.Forms.Label UpdateBarLabel;
        private System.Windows.Forms.Timer ProgressTimer;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button ForceUpdate;
    }
}

