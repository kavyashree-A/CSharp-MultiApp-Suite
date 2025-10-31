using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoList
{
    public partial class Form1 : Form
    {
        private TaskManager taskManager;
        private bool isDarkMode = true;

        public Form1()
        {
            InitializeComponent();
            taskManager = new TaskManager();
            listBoxTasks.AllowDrop = true;
            // Drag & Drop events
            listBoxTasks.MouseDown += ListBoxTasks_MouseDown;
            listBoxTasks.DragOver += ListBoxTasks_DragOver;
            listBoxTasks.DragDrop += ListBoxTasks_DragDrop;

            RefreshTaskList();
        }

        private void RefreshTaskList()
        {
            listBoxTasks.Items.Clear();
            foreach (var task in taskManager.Tasks)
                listBoxTasks.Items.Add(task);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTask.Text))
            {
                taskManager.AddTask(new Task(txtTask.Text));
                txtTask.Clear();
                RefreshTaskList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem != null && !string.IsNullOrWhiteSpace(txtTask.Text))
            {
                var task = (Task)listBoxTasks.SelectedItem;
                task.Title = txtTask.Text;
                taskManager.SaveTasks();
                txtTask.Clear();
                RefreshTaskList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem != null)
            {
                taskManager.RemoveTask((Task)listBoxTasks.SelectedItem);
                RefreshTaskList();
            }
        }

        private void btnToggleComplete_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem != null)
            {
                var task = (Task)listBoxTasks.SelectedItem;
                task.IsCompleted = !task.IsCompleted;
                taskManager.SaveTasks();
                RefreshTaskList();
            }
        }

        private void btnToggleTheme_Click(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode;

            if (isDarkMode)
            {
                this.BackColor = Color.FromArgb(44, 62, 80);
                listBoxTasks.BackColor = Color.FromArgb(52, 73, 94);
                listBoxTasks.ForeColor = Color.White;
                txtTask.BackColor = Color.FromArgb(52, 73, 94);
                txtTask.ForeColor = Color.White;
                lbl_txttask.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                listBoxTasks.BackColor = Color.White;
                listBoxTasks.ForeColor = Color.Black;
                txtTask.BackColor = Color.White;
                txtTask.ForeColor = Color.Black;
                lbl_txttask.ForeColor = Color.Black;
            }

            // Update buttons
            foreach (var ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = isDarkMode ? Color.FromArgb(52, 152, 219) : Color.LightGray;
                    btn.ForeColor = isDarkMode ? Color.White : Color.Black;
                }
            }
        }

        // Drag & Drop events
        private void ListBoxTasks_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBoxTasks.SelectedItem == null) return;
            listBoxTasks.DoDragDrop(listBoxTasks.SelectedItem, DragDropEffects.Move);
        }

        private void ListBoxTasks_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void ListBoxTasks_DragDrop(object sender, DragEventArgs e)
        {
            var point = listBoxTasks.PointToClient(new Point(e.X, e.Y));
            int index = listBoxTasks.IndexFromPoint(point);
            if (index < 0) index = listBoxTasks.Items.Count - 1;

            var task = (Task)e.Data.GetData(typeof(Task));
            taskManager.Tasks.Remove(task);
            taskManager.Tasks.Insert(index, task);
            taskManager.SaveTasks();
            RefreshTaskList();
        }
    }
}