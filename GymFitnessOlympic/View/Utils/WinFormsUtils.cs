using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QldtSdh.GUI.Utils
{
    static class WinFormsUtils
    {
        public static void SetDataGridViewAsListBox(this System.Windows.Forms.DataGridView grid, bool rowHeadersVisible = false, bool columnHeadersVisible = false)
        {
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToOrderColumns = false;
            grid.AllowUserToResizeColumns = false;
            grid.AllowUserToResizeRows = false;

            grid.RowHeadersVisible = rowHeadersVisible;
            grid.ColumnHeadersVisible = columnHeadersVisible;
            grid.BackgroundColor = System.Drawing.SystemColors.Window;
            grid.GridColor = grid.BackgroundColor;

            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //grid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Gainsboro;
            grid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
        }

        public static void SetDataGridViewAsReadonly(this System.Windows.Forms.DataGridView grid, bool rowHeadersVisible = false, bool columnHeadersVisible = false)
        {
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToOrderColumns = false;
            grid.AllowUserToResizeColumns = false;
            grid.AllowUserToResizeRows = false;

            grid.RowHeadersVisible = rowHeadersVisible;
            grid.ColumnHeadersVisible = columnHeadersVisible;
            //grid.BackgroundColor = System.Drawing.SystemColors.Window;
            //grid.GridColor = grid.BackgroundColor;

            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
        }

        #region public static void AddRowIndexing(this DataGridView grid)
        public static void AddRowIndexing(this DataGridView grid)
        {
            if (grid.RowHeadersVisible)
                grid.RowPostPaint += OnRowPostPaint;
        }

        private static void OnRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView grid = sender as DataGridView;
            if (grid.RowHeadersVisible && e.RowIndex >= 0)
            {
                string strRowNumber = (e.RowIndex + 1).ToString();
                System.Drawing.SizeF size = e.Graphics.MeasureString(strRowNumber, grid.Font);
                if (grid.RowHeadersWidth < (int)(size.Width + 20))
                    grid.RowHeadersWidth = (int)(size.Width + 20);
                if (grid.NewRowIndex == e.RowIndex)
                    e.Graphics.DrawString(strRowNumber, grid.Font, System.Drawing.Brushes.LightGray,
                                        e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
                else
                    e.Graphics.DrawString(strRowNumber, grid.Font, System.Drawing.Brushes.Black,
                        e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
        }
        #endregion

        public static void SetDataSource(this DataGridView grid, BindingSource bs)
        {
            grid.AutoGenerateColumns = false;
            grid.DataSource = bs;
        }

        public static void ScrollToLast(this TextBox txt)
        {
            txt.Select(txt.Text.Length, 0);
            txt.ScrollToCaret();
        }

        public static void MatchSelectedIndex(this ComboBox cbx, string value)
        {
            cbx.SelectedIndex = -1;
            for (int i = 0; i < cbx.Items.Count; i++)
                if (cbx.Items[i].ToString() == value)
                {
                    cbx.SelectedIndex = i;
                    break;
                }
        }

        /// <summary>
        /// Thiết lập vị trí của record cho datagridview "grid".
        /// grid phải đang có DataSource là một BindingSource
        /// </summary>
        /// <param name="grid"></param>
        public static void UpdatePosAfterDeleteRecord(this DataGridView grid)
        {
            try
            {
                var bs = grid.DataSource as BindingSource;
                grid.DataSource = null;
                var oldIdx = bs.Position;
                bs.RemoveCurrent();
                grid.SetDataSource(bs);
                if (bs.Count > 0)
                {
                    if (oldIdx >= bs.Count)
                        oldIdx = bs.Count - 1;
                    bs.Position = oldIdx;
                }
            }
            catch { }
        }

        public static string Append(this string st, string value, string sep = "; ")
        {
            if (string.IsNullOrEmpty(st))
                return value;
            else
                return st + sep + value;
        }
    }
}
