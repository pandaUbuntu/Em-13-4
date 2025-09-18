using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsApp2.entity;

namespace WindowsFormsApp2.database
{
    class CommentsRepository
    {
        private readonly MySqlConnection _connection;
        public CommentsRepository() {
            _connection = DatabaseConnection.GetConnection(database: "advance1");
        }

        // CRUD - Create, Read, Update, Delete
        // Create
        public bool AddComment(int rating, string text)
        {

            using (var command = new MySqlCommand("INSERT INTO comments (rating, text, createdAt) VALUES (@rating, @text, @createdAt)", _connection))
            {
                command.Parameters.AddWithValue("@rating", rating);
                command.Parameters.AddWithValue("@text", text);
                command.Parameters.AddWithValue("@createdAt", DateTime.Now);

                try
                {
                    _connection.Open();
                    int count = command.ExecuteNonQuery();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageService.ShowErrorEx(ex);
                    return false;
                }
                finally
                {
                    _connection.Close();
                }
            }
        }

        // Read
        public Comment GetCommentById(int id)
        {
            using (var command = new MySqlCommand("SELECT * FROM comments WHERE id = @id", _connection))
            {
                command.Parameters.AddWithValue("@id", id);
                try
                {
                    _connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Comment(
                                reader.GetInt32("id"),
                                reader.GetInt32("rating"),
                                reader.GetString("text"),
                                reader.GetDateTime("createdAt")
                            );
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageService.ShowErrorEx(ex);
                }
                finally
                {
                    _connection.Close();
                }
            }
            return null;
        }

        // Update
        public bool UpdateComment(int id, int rating, string text)
        {
            using (var command = new MySqlCommand("UPDATE comments SET rating = @rating, text = @text WHERE id = @id", _connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@rating", rating);
                command.Parameters.AddWithValue("@text", text);
                try
                {
                    _connection.Open();
                    int count = command.ExecuteNonQuery();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageService.ShowErrorEx(ex);
                    return false;
                }
                finally
                {
                    _connection.Close();
                }
            }
        }

        // Delete
        public bool DeleteComment(int id)
        {
            using (var command = new MySqlCommand("DELETE FROM comments WHERE id = @id", _connection))
            {
                command.Parameters.AddWithValue("@id", id);
                try
                {
                    _connection.Open();
                    int count = command.ExecuteNonQuery();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageService.ShowErrorEx(ex);
                    return false;
                }
                finally
                {
                    _connection.Close();
                }
            }
        }
    }
}
