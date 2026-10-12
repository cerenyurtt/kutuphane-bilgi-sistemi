using KutuphaneBS.Service.Core;
using KutuphaneBS.Service.Model;


namespace KutuphaneBS.UI
{
    public partial class Form1 : Form
    {
        TurService _turService;
        int seciliId;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var db = new KutuphaneDB();
            _turService = new TurService(db);
            GridDoldur();
        }

        private void GridDoldur()
        {
            var turler = _turService.Listele();

            dataGridView1.DataSource = turler.Select(p => new
            {
                Id = p.Id,
                Adi = p.Adi,
            }).ToList();
            dataGridView1.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (seciliId == 0)
            {
                var tur = new Tur();
                tur.Adi = txtAdi.Text;
                _turService.Ekle(tur);
                txtAdi.Clear();
            }
            else
            {
                var tur = _turService.Getir(seciliId);
                tur.Adi = txtAdi.Text;
                _turService.Guncelle(tur);
                txtAdi.Clear();
                seciliId = 0;
            }
              
            GridDoldur();
        }

        private void bntSil_Click(object sender, EventArgs e)
        {
            var id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
            //MessageBox.Show(id.ToString());
            _turService.Sil(id);

            GridDoldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            seciliId = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;

            var tur = _turService.Getir(seciliId);
            txtAdi.Text = tur.Adi;


            // _turService.Guncelle(id);

        }
    }
}
