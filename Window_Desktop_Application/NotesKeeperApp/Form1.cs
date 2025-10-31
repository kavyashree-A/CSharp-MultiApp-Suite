using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NotesKeeperApp
{
    public partial class Form1 : Form
    {
        private List<Note> notes = new List<Note>();
        private string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "notes.txt");

        public Form1()
        {
            InitializeComponent();
            LoadNotes();
            lblStatus.Text = "Ready";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string content = rtbContent.Text.Trim();

            if (string.IsNullOrEmpty(title))
            {
                lblStatus.Text = "⚠️ Please enter a title.";
                return;
            }

            var existing = notes.FirstOrDefault(n => n.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (existing != null)
            {
                existing.Content = content;
                lblStatus.Text = "✏️ Note updated.";
            }
            else
            {
                notes.Add(new Note { Title = title, Content = content });
                lblStatus.Text = "✅ Note added!";
            }

            UpdateList();
            SaveNotes();
            ClearInputs();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstNotes.SelectedIndex < 0)
            {
                lblStatus.Text = "⚠️ Select a note to edit.";
                return;
            }

            var selectedNote = notes[lstNotes.SelectedIndex];
            txtTitle.Text = selectedNote.Title;
            rtbContent.Text = selectedNote.Content;
            lblStatus.Text = "✏️ Editing note.";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstNotes.SelectedIndex >= 0)
            {
                notes.RemoveAt(lstNotes.SelectedIndex);
                UpdateList();
                SaveNotes();
                lblStatus.Text = "🗑️ Note deleted.";
            }
            else
            {
                lblStatus.Text = "⚠️ Please select a note to delete.";
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = txtSearch.Text.ToLower();
            var filtered = notes.Where(n => n.Title.ToLower().Contains(query)).ToList();
            lstNotes.Items.Clear();
            foreach (var n in filtered)
                lstNotes.Items.Add(n.Title);
        }

        private void lstNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNotes.SelectedIndex >= 0)
            {
                var selectedNote = notes[lstNotes.SelectedIndex];
                txtTitle.Text = selectedNote.Title;
                rtbContent.Text = selectedNote.Content;
            }
        }

        private void LoadNotes()
        {
            notes = new List<Note>();
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(new string[] { "|||" }, StringSplitOptions.None);
                    if (parts.Length >= 2)
                        notes.Add(new Note { Title = parts[0], Content = parts[1] });
                }
                UpdateList();
            }
        }

        private void SaveNotes()
        {
            var lines = notes.Select(n => $"{n.Title}|||{n.Content}").ToArray();
            File.WriteAllLines(filePath, lines);
        }

        private void UpdateList()
        {
            lstNotes.Items.Clear();
            foreach (var n in notes)
                lstNotes.Items.Add(n.Title);
        }

        private void ClearInputs()
        {
            txtTitle.Clear();
            rtbContent.Clear();
        }
    }
}
