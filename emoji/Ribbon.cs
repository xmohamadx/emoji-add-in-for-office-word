using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;

namespace emoji
{
    public partial class Ribbon
    {
        void emojiInserter(string emoji)
        {
            Word.Selection currentSelection = Globals.ThisAddIn.Application.Selection;
            currentSelection.TypeText(emoji);
        }

        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {
            
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("1️⃣");
        }


        private void No2_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("2️⃣");
        }

        private void No3_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("3️⃣");
        }

        private void No4_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("4️⃣");
        }

        private void No5_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("5️⃣");
        }

        private void No6_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("6️⃣");
        }

        private void No7_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("7️⃣");
        }

        private void No8_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("8️⃣");
        }

        private void No9_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("9️⃣");
        }

        private void No10_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("🔟");
        }

        private void Orange_book_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("📙");
        }

        private void Left_pointing_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("◀️");
        }

        private void Right_pointing_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("▶️");
        }

        private void up_pointing_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("🔼");
        }

        private void down_pointing_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("🔽");
        }

        private void Red_book_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("📕");
        }

        private void mega_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("📣");
        }

        private void loudspeaker_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("📢");
        }

        private void rose_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("🌹");
        }

        private void hibiscus_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("🌺");
        }

        private void blossom_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("🌼");
        }

        private void cherry_blossom_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("🌸");
        }

        private void tulip_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("🌷");
        }

        private void maple_leaf_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("🍁");
        }

        private void fallen_leaf_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("🍂");
        }

        private void shamrock_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("☘️");
        }

        private void point_up_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("👆");
        }

        private void point_down_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("👇");
        }

        private void point_left_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("👈");
        }

        private void point_right_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("👉");
        }

        private void pray_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("🙏");
        }

        private void writing_hand_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("✍️");
        }

        private void moon_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("🌒");
        }

        private void red_circle_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("🔴");
        }

        private void blue_circle_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("🔵");
        }

        private void small_orange_diamond_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("🔸");
        }

        private void small_blue_diamond_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("🔹");
        }

        private void large_orange_diamond_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("🔶");
        }

        private void large_blue_diamond_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("🔷");
        }

        private void black_circle_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("⚫️");
        }

        private void white_circle_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("⚪️");
        }

        private void black_medium_square_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("◼️");
        }

        private void white_medium_square_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("◻️");
        }

        private void black_medium_small_square_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("◾️");
        }

        private void white_medium_small_square_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("◽️");
        }

        private void black_small_square_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("▪️");
        }

        private void white_small_square_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("▫️");
        }

        private void black_checkbox_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("☑️");
        }

        private void green_checkbox_Click(object sender, RibbonControlEventArgs e)
        {
            emojiInserter("✅");
        }
    }
}
