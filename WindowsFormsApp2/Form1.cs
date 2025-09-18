using System;
using System.Windows.Forms;
using WindowsFormsApp2.database;
using WindowsFormsApp2.entity;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private CommentsRepository _commentsRepository;
        public Form1()
        {
            InitializeComponent();
            _commentsRepository = new CommentsRepository();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = this.CreateCommentText.Text;
            int rating = Convert.ToInt32(this.CreateCommentRating.Text);

            if (string.IsNullOrWhiteSpace(text))
            {
                MessageService.ShowWarning("Please enter a valid comment");
                return;
            }

            if (rating < 1 || rating > 5)
            {
                MessageService.ShowWarning("Please enter a valid rating (1-5).");
                return;
            }

            if (_commentsRepository.AddComment(rating, text))
            {
                MessageService.ShowInfo("Comment added successfully!");
                this.CreateCommentText.Text = "";
                this.CreateCommentRating.Text = "";
            }
            else
            {
                MessageService.ShowError("Failed to add comment.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.UpdateCommentID.Text);

            Comment comment = _commentsRepository.GetCommentById(id);

            if (comment != null)
            {
                this.UpdateCommentText.Text = comment.Text;
                this.UpdateCommentRating.Text = comment.Rating.ToString();
            }
            else
            {
                MessageService.ShowError("Comment not found.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text = this.UpdateCommentText.Text;
            int rating = Convert.ToInt32(this.UpdateCommentRating.Text);
            int id = Convert.ToInt32(this.UpdateCommentID.Text);

            if (id <= 0)
            {
                MessageService.ShowWarning("Please ID ");
                return;
            }

            if (string.IsNullOrWhiteSpace(text))
            {
                MessageService.ShowWarning("Please enter a valid comment. Test text");
                return;
            }

            if (rating < 1 || rating > 5)
            {
                MessageService.ShowWarning("Please enter a valid rating (1-5).");
                return;
            }

            if (_commentsRepository.UpdateComment(id, rating, text))
            {
                MessageService.ShowInfo("Comment updated successfully!");
                this.UpdateCommentText.Text = "";
                this.UpdateCommentID.Text = "";
            }
            else
            {
                MessageService.ShowError("Failed to update comment.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.DeleteCommentID.Text);

            if (id <= 0)
            {
                MessageService.ShowWarning("Please enter a valid ID ");
                return;
            }

            if (_commentsRepository.DeleteComment(id))
            {
                MessageService.ShowInfo("Comment deleted successfully!");
                this.DeleteCommentID.Text = "";
            }
            else
            {
                MessageService.ShowError("Failed to delete comment.");
            }
        }
    }
}
