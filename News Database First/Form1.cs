using Microsoft.EntityFrameworkCore;
using News_Database_First.Models;

namespace News_Database_First
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewsDbContext db = new NewsDbContext();
            AllNews.DataSource = db.News.Include(n => n.Auth).Include(x=>x.Cat).ToList();
            
        }
    }
}
