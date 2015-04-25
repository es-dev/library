#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using Library.Code;

#endregion

namespace Library.Controls
{
    public partial class PagingContainer : UserControl
    {
        private IList<Gizmox.WebGUI.Forms.Control> pagingControls = null;
        public IList<Gizmox.WebGUI.Forms.Control> PagingControls
        {
            get
            {
                return pagingControls;
            }
            set
            {
                pagingControls = value;
                LoadControls(pagingControls);
            }
        }
             
        private int count=0;
        public int Count 
        { 
            get 
            {
                return count; 
            } 
            set 
            {
                count = value; 
            } 
        }

        public PagingContainer()
        {
            InitializeComponent();           
        }

        private int page = 1;

        private void LoadControls(IList<Gizmox.WebGUI.Forms.Control> pagingControls)
        {
            try
            {
                int take = GetTake();
                int pages = GetPages(take);
                int skip = (page - 1) * take;
                container.Controls.Clear();
                if (HasControls())
                {
                    var pageControls = (from q in pagingControls select q).Skip(skip).Take(take);
                    foreach (var pageControl in pageControls)
                        container.Controls.Add(pageControl);
                }
                LoadNextControls(take);
                SetLayoutPaging(pages);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SetLayoutPaging(int pages)
        {
            try
            {
                btnNext.Visible = (pages >= 1) && (page < pages);
                btnPrevious.Visible = (pages >= 1) && (page > 1);
                lblPagingNext.Visible = btnNext.Visible;
                lblPagingPrevious.Visible = (!lblPagingNext.Visible && btnPrevious.Visible);
                if (pages > 1)
                {
                    lblPagingNext.Text = page.ToString() + "/" + pages.ToString();
                    lblPagingPrevious.Text = lblPagingNext.Text;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void LoadNextControls(int take)
        {
            try
            {
                int countLoaded = 0;
                if(HasControls())
                    countLoaded = pagingControls.Count;
                int countToLoad = page * take;
                if (countToLoad > countLoaded && countLoaded < count)
                {
                    if (CanLoad != null)
                        CanLoad();
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private int GetTake()
        {
            try
            {
                if (HasControls())
                {
                    var control = pagingControls[0];
                    int width = container.Width;
                    int height = container.Height;
                    var margin = control.Margin;
                    if (margin != null)
                    {
                        int itemWidth = control.Width + margin.Right + margin.Left;
                        int itemHeight = control.Height + margin.Top + margin.Bottom;
                        int cols = width / itemWidth;
                        int rows = height / itemHeight;
                        int take = rows * cols;
                        return take;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        private int GetPages(int take)
        {
            try
            {
                if (take > 0)
                {
                    int pages = (int)((decimal)(count-1) / take) + 1;
                    return pages;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        private bool HasControls()
        {
            try
            {
                bool hasControls = (pagingControls != null && pagingControls.Count > 0);
                return hasControls;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        private void flowContainer_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                int take = GetTake();
                int pages = GetPages(take);
                if (pages > 0)
                {
                    if (page > pages)
                        page = pages;
                    LoadControls(pagingControls);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public delegate void CanLoadHanlder();
        public event CanLoadHanlder CanLoad;

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                int take = GetTake();
                int pages = GetPages(take);
                if (pages > 0)
                {
                    page += 1;
                    if (page >= pages)
                        page = pages;
                    LoadControls(pagingControls);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
        
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                page -= 1;
                if (page < 1)
                    page = 1;
                LoadControls(pagingControls);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

    }
}