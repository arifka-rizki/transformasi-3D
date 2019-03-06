using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Bitmap btm;
        Graphics g;
        Graphics fG;
        Pen p;
        PointF cursor;
        int maksimal;
        PointF[] PointFH = new PointF[78];
        PointF[] PointFR = new PointF[78];
        float[] selisihX = new float[78];
        float[] selisihY = new float[78];
        int frame = 60;
        
        public Form1()
        {
            btm = new Bitmap(400, 400);
            fG = Graphics.FromImage(btm);
            InitializeComponent();
            g = this.CreateGraphics();
            p = new Pen(Color.Black, 2);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            cursor = this.PointToClient(Cursor.Position);
            mouseStatus.Text = "X: " + cursor.X + " Y: " + cursor.Y;
        }

        protected void drawHippo(object sender, EventArgs e)
        {
            List<PointF> hippo = new List<PointF>()
            {
                new PointF(101, 400-90),
                new PointF(106, 400-89),
                new PointF(117, 400-77),
                new PointF(130, 400-66),
                new PointF(143, 400-57),
                new PointF(147, 400-42),
                new PointF(148, 400-30),
                new PointF(147, 400-15),
                new PointF(142, 400-7),
                new PointF(147, 400-3),
                new PointF(165, 400-4),
                new PointF(173, 400-13),
                new PointF(176, 400-35),
                new PointF(182, 400-28),
                new PointF(186, 400-17),
                new PointF(182, 400-9),
                new PointF(182, 400-4),
                new PointF(201, 400-3),
                new PointF(210, 400-11),
                new PointF(207, 400-26),
                new PointF(205, 400-42),
                new PointF(200, 400-50),
                new PointF(223, 400-44),
                new PointF(242, 400-42),
                new PointF(278, 400-42),
                new PointF(303, 400-49),
                new PointF(313, 400-53),
                new PointF(316, 400-55),
                new PointF(317, 400-46),
                new PointF(317, 400-35),
                new PointF(316, 400-25),
                new PointF(312, 400-15),
                new PointF(308, 400-7),
                new PointF(313, 400-3),
                new PointF(328, 400-3),
                new PointF(335, 400-8),
                new PointF(341, 400-19),
                new PointF(345, 400-31),
                new PointF(349, 400-51),
                new PointF(351, 400-61),
                new PointF(360, 400-55),
                new PointF(366, 400-45),
                new PointF(369, 400-30),
                new PointF(368, 400-20),
                new PointF(365, 400-13),
                new PointF(365, 400-5),
                new PointF(385, 400-5),
                new PointF(390, 400-15),
                new PointF(393, 400-33),
                new PointF(395, 400-53),
                new PointF(392, 400-61),
                new PointF(396, 400-91),
                new PointF(399, 400-99),
                new PointF(401, 400-108),
                new PointF(400, 400-130),
                new PointF(393, 400-151),
                new PointF(378, 400-165),
                new PointF(340, 400-181),
                new PointF(290, 400-180),
                new PointF(227, 400-176),
                new PointF(195, 400-173),
                new PointF(174, 400-177),
                new PointF(156, 400-180),
                new PointF(123, 400-184),
                new PointF(103, 400-181),
                new PointF(86, 400-170),
                new PointF(73, 400-167),
                new PointF(64, 400-162),
                new PointF(64, 400-152),
                new PointF(51, 400-140),
                new PointF(33, 400-134),
                new PointF(13, 400-133),
                new PointF(6, 400-128),
                new PointF(4, 400-114),
                new PointF(12, 400-93),
                new PointF(23, 400-84),
                new PointF(44, 400-75),
                new PointF(59, 400-73),
                new PointF(79, 400-77),
            };
            maksimal = hippo.Count();
            PointFH = hippo.ToArray();
            Gambar(1);
        }

        protected void drawRabbit(object sender, EventArgs e)
        {
            List<PointF> rabbit = new List<PointF>()
            {
                new PointF(84, 400-131),
                new PointF(87, 400-120),
                new PointF(95, 400-104),
                new PointF(106, 400-89),
                new PointF(125, 400-77),
                new PointF(143, 400-65),
                new PointF(144, 400-58),
                new PointF(142, 400-32),
                new PointF(137, 400-24),
                new PointF(124, 400-17),
                new PointF(118, 400-9),
                new PointF(117, 400-2),
                new PointF(121, 400-2),
                new PointF(156, 400-2),
                new PointF(166, 400-14),
                new PointF(172, 400-43),
                new PointF(179, 400-50),
                new PointF(243, 400-29),
                new PointF(244, 400-26),
                new PointF(230, 400-20),
                new PointF(225, 400-7),
                new PointF(225, 400-3),
                new PointF(318, 400-3),
                new PointF(319, 400-12),
                new PointF(316, 400-18),
                new PointF(341, 400-21),
                new PointF(363, 400-27),
                new PointF(373, 400-32),
                new PointF(378, 400-23),
                new PointF(389, 400-18),
                new PointF(407, 400-24),
                new PointF(417, 400-35),
                new PointF(415, 400-50),
                new PointF(403, 400-54),
                new PointF(392, 400-54),
                new PointF(394, 400-72),
                new PointF(392, 400-88),
                new PointF(386, 400-108),
                new PointF(373, 400-123),
                new PointF(360, 400-134),
                new PointF(328, 400-145),
                new PointF(303, 400-152),
                new PointF(268, 400-155),
                new PointF(235, 400-162),
                new PointF(205, 400-165),
                new PointF(175, 400-168),
                new PointF(168, 400-170),
                new PointF(162, 400-177),
                new PointF(157, 400-194),
                new PointF(155, 400-201),
                new PointF(169, 400-217),
                new PointF(174, 400-223),
                new PointF(173, 400-251),
                new PointF(170, 400-265),
                new PointF(158, 400-267),
                new PointF(142, 400-262),
                new PointF(135, 400-260),
                new PointF(153, 400-267),
                new PointF(143, 400-269),
                new PointF(131, 400-265),
                new PointF(123, 400-260),
                new PointF(117, 400-255),
                new PointF(115, 400-245),
                new PointF(113, 400-240),
                new PointF(112, 400-232),
                new PointF(111, 400-224),
                new PointF(110, 400-216),
                new PointF(110, 400-213),
                new PointF(102, 400-211),
                new PointF(95, 400-208),
                new PointF(85, 400-203),
                new PointF(73, 400-196),
                new PointF(59, 400-187),
                new PointF(49, 400-180),
                new PointF(37, 400-167),
                new PointF(36, 400-156),
                new PointF(44, 400-147),
                new PointF(59, 400-137),
                new PointF(74, 400-132),
            };
            PointFR = rabbit.ToArray();
            Gambar(2);
        }

        private void Gambar(int j)
        {
            if (j == 1)
            {
                g.Clear(Color.WhiteSmoke);
                for (int i = 0; i < 78; i++)
                {
                    g.DrawLine(p, PointFH[i], PointFH[i + 1]);
                }
                g.DrawLine(p, PointFH[78], PointFH[0]);
            }
            else
            {
                g.Clear(Color.WhiteSmoke);
                for (int i = 0; i < 78; i++)
                {
                    g.DrawLine(p, PointFR[i], PointFR[i + 1]);
                }
                g.DrawLine(p, PointFR[78], PointFR[0]);
            }
            
        }

        private void animateClick(object sender, EventArgs e)
        {
            for (int i = 0; i < 78; i++)
            {
                //selisihX[i] = (float)Math.Sqrt(Math.Pow((PointFH[i].X-PointFR[i].X), 2) + Math.Pow((PointFH[i].Y-PointFR[i].Y), 2));
                selisihX[i] = PointFH[i].X - PointFR[i].X;
                selisihY[i] = PointFH[i].Y - PointFR[i].Y;
                
            }
            for (int j = 0; j < frame; j++)
            {
                for (int i = 0; i < 78; i++)
                {
                    PointFH[i].X -= (selisihX[i]/frame);
                    PointFH[i].Y -= (selisihY[i]/frame);
                }
                animate();
            }

        }

        private void animate()
        {
            for (int i = 0; i < 5000; i++) Console.Write("haha");
            g.Clear(Color.WhiteSmoke);
            for (int i=0; i < 78; i++)
            {
                
                if(i==77) g.DrawLine(p, PointFH[77], PointFH[0]);
                else g.DrawLine(p, PointFH[i], PointFH[i + 1]);
            }
        }
    }
}
