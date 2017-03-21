namespace emoji
{
    partial class Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.emoji = this.Factory.CreateRibbonTab();
            this.emoji_group = this.Factory.CreateRibbonGroup();
            this.No1 = this.Factory.CreateRibbonButton();
            this.No2 = this.Factory.CreateRibbonButton();
            this.No3 = this.Factory.CreateRibbonButton();
            this.No4 = this.Factory.CreateRibbonButton();
            this.No5 = this.Factory.CreateRibbonButton();
            this.No6 = this.Factory.CreateRibbonButton();
            this.No7 = this.Factory.CreateRibbonButton();
            this.No8 = this.Factory.CreateRibbonButton();
            this.No9 = this.Factory.CreateRibbonButton();
            this.No10 = this.Factory.CreateRibbonButton();
            this.Left_pointing = this.Factory.CreateRibbonButton();
            this.Right_pointing = this.Factory.CreateRibbonButton();
            this.Red_book = this.Factory.CreateRibbonButton();
            this.Orange_book = this.Factory.CreateRibbonButton();
            this.mega = this.Factory.CreateRibbonButton();
            this.loudspeaker = this.Factory.CreateRibbonButton();
            this.rose = this.Factory.CreateRibbonButton();
            this.hibiscus = this.Factory.CreateRibbonButton();
            this.blossom = this.Factory.CreateRibbonButton();
            this.cherry_blossom = this.Factory.CreateRibbonButton();
            this.tulip = this.Factory.CreateRibbonButton();
            this.maple_leaf = this.Factory.CreateRibbonButton();
            this.fallen_leaf = this.Factory.CreateRibbonButton();
            this.shamrock = this.Factory.CreateRibbonButton();
            this.point_up = this.Factory.CreateRibbonButton();
            this.point_down = this.Factory.CreateRibbonButton();
            this.point_left = this.Factory.CreateRibbonButton();
            this.point_right = this.Factory.CreateRibbonButton();
            this.pray = this.Factory.CreateRibbonButton();
            this.writing_hand = this.Factory.CreateRibbonButton();
            this.moon = this.Factory.CreateRibbonButton();
            this.red_circle = this.Factory.CreateRibbonButton();
            this.blue_circle = this.Factory.CreateRibbonButton();
            this.small_orange_diamond = this.Factory.CreateRibbonButton();
            this.small_blue_diamond = this.Factory.CreateRibbonButton();
            this.large_orange_diamond = this.Factory.CreateRibbonButton();
            this.large_blue_diamond = this.Factory.CreateRibbonButton();
            this.black_circle = this.Factory.CreateRibbonButton();
            this.white_circle = this.Factory.CreateRibbonButton();
            this.black_medium_square = this.Factory.CreateRibbonButton();
            this.white_medium_square = this.Factory.CreateRibbonButton();
            this.black_medium_small_square = this.Factory.CreateRibbonButton();
            this.white_medium_small_square = this.Factory.CreateRibbonButton();
            this.black_small_square = this.Factory.CreateRibbonButton();
            this.white_small_square = this.Factory.CreateRibbonButton();
            this.black_checkbox = this.Factory.CreateRibbonButton();
            this.green_checkbox = this.Factory.CreateRibbonButton();
            this.down_pointing = this.Factory.CreateRibbonButton();
            this.up_pointing = this.Factory.CreateRibbonButton();
            this.emoji.SuspendLayout();
            this.emoji_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // emoji
            // 
            this.emoji.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.emoji.Groups.Add(this.emoji_group);
            this.emoji.Label = "Emoji";
            this.emoji.Name = "emoji";
            // 
            // emoji_group
            // 
            this.emoji_group.Items.Add(this.No1);
            this.emoji_group.Items.Add(this.Left_pointing);
            this.emoji_group.Items.Add(this.Right_pointing);
            this.emoji_group.Items.Add(this.No2);
            this.emoji_group.Items.Add(this.up_pointing);
            this.emoji_group.Items.Add(this.down_pointing);
            this.emoji_group.Items.Add(this.No3);
            this.emoji_group.Items.Add(this.loudspeaker);
            this.emoji_group.Items.Add(this.Orange_book);
            this.emoji_group.Items.Add(this.No4);
            this.emoji_group.Items.Add(this.mega);
            this.emoji_group.Items.Add(this.Red_book);
            this.emoji_group.Items.Add(this.No5);
            this.emoji_group.Items.Add(this.rose);
            this.emoji_group.Items.Add(this.hibiscus);
            this.emoji_group.Items.Add(this.No6);
            this.emoji_group.Items.Add(this.blossom);
            this.emoji_group.Items.Add(this.cherry_blossom);
            this.emoji_group.Items.Add(this.No7);
            this.emoji_group.Items.Add(this.tulip);
            this.emoji_group.Items.Add(this.maple_leaf);
            this.emoji_group.Items.Add(this.No8);
            this.emoji_group.Items.Add(this.fallen_leaf);
            this.emoji_group.Items.Add(this.shamrock);
            this.emoji_group.Items.Add(this.No9);
            this.emoji_group.Items.Add(this.point_up);
            this.emoji_group.Items.Add(this.point_down);
            this.emoji_group.Items.Add(this.No10);
            this.emoji_group.Items.Add(this.point_left);
            this.emoji_group.Items.Add(this.point_right);
            this.emoji_group.Items.Add(this.pray);
            this.emoji_group.Items.Add(this.writing_hand);
            this.emoji_group.Items.Add(this.moon);
            this.emoji_group.Items.Add(this.red_circle);
            this.emoji_group.Items.Add(this.blue_circle);
            this.emoji_group.Items.Add(this.small_orange_diamond);
            this.emoji_group.Items.Add(this.small_blue_diamond);
            this.emoji_group.Items.Add(this.large_orange_diamond);
            this.emoji_group.Items.Add(this.large_blue_diamond);
            this.emoji_group.Items.Add(this.black_circle);
            this.emoji_group.Items.Add(this.white_circle);
            this.emoji_group.Items.Add(this.black_medium_square);
            this.emoji_group.Items.Add(this.white_medium_square);
            this.emoji_group.Items.Add(this.black_medium_small_square);
            this.emoji_group.Items.Add(this.white_medium_small_square);
            this.emoji_group.Items.Add(this.black_small_square);
            this.emoji_group.Items.Add(this.white_small_square);
            this.emoji_group.Items.Add(this.black_checkbox);
            this.emoji_group.Items.Add(this.green_checkbox);
            this.emoji_group.Label = "emoji";
            this.emoji_group.Name = "emoji_group";
            // 
            // No1
            // 
            this.No1.Image = global::emoji.Properties.Resources.No1;
            this.No1.Label = "No1";
            this.No1.Name = "No1";
            this.No1.ShowImage = true;
            this.No1.ShowLabel = false;
            this.No1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
            // 
            // No2
            // 
            this.No2.Image = global::emoji.Properties.Resources.No2;
            this.No2.Label = "No2";
            this.No2.Name = "No2";
            this.No2.ShowImage = true;
            this.No2.ShowLabel = false;
            this.No2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.No2_Click);
            // 
            // No3
            // 
            this.No3.Image = global::emoji.Properties.Resources.No3;
            this.No3.Label = "No3";
            this.No3.Name = "No3";
            this.No3.ShowImage = true;
            this.No3.ShowLabel = false;
            this.No3.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.No3_Click);
            // 
            // No4
            // 
            this.No4.Image = global::emoji.Properties.Resources.No4;
            this.No4.Label = "No4";
            this.No4.Name = "No4";
            this.No4.ShowImage = true;
            this.No4.ShowLabel = false;
            this.No4.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.No4_Click);
            // 
            // No5
            // 
            this.No5.Image = global::emoji.Properties.Resources.No5;
            this.No5.Label = "No5";
            this.No5.Name = "No5";
            this.No5.ShowImage = true;
            this.No5.ShowLabel = false;
            this.No5.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.No5_Click);
            // 
            // No6
            // 
            this.No6.Image = global::emoji.Properties.Resources.No6;
            this.No6.Label = "No6";
            this.No6.Name = "No6";
            this.No6.ShowImage = true;
            this.No6.ShowLabel = false;
            this.No6.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.No6_Click);
            // 
            // No7
            // 
            this.No7.Image = global::emoji.Properties.Resources.No7;
            this.No7.Label = "No7";
            this.No7.Name = "No7";
            this.No7.ShowImage = true;
            this.No7.ShowLabel = false;
            this.No7.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.No7_Click);
            // 
            // No8
            // 
            this.No8.Image = global::emoji.Properties.Resources.No8;
            this.No8.Label = "No8";
            this.No8.Name = "No8";
            this.No8.ShowImage = true;
            this.No8.ShowLabel = false;
            this.No8.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.No8_Click);
            // 
            // No9
            // 
            this.No9.Image = global::emoji.Properties.Resources.No9;
            this.No9.Label = "No9";
            this.No9.Name = "No9";
            this.No9.ShowImage = true;
            this.No9.ShowLabel = false;
            this.No9.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.No9_Click);
            // 
            // No10
            // 
            this.No10.Image = global::emoji.Properties.Resources.No10;
            this.No10.Label = "No10";
            this.No10.Name = "No10";
            this.No10.ShowImage = true;
            this.No10.ShowLabel = false;
            this.No10.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.No10_Click);
            // 
            // Left_pointing
            // 
            this.Left_pointing.Image = global::emoji.Properties.Resources._25c0;
            this.Left_pointing.Label = "Left_pointing";
            this.Left_pointing.Name = "Left_pointing";
            this.Left_pointing.ShowImage = true;
            this.Left_pointing.ShowLabel = false;
            this.Left_pointing.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Left_pointing_Click);
            // 
            // Right_pointing
            // 
            this.Right_pointing.Image = global::emoji.Properties.Resources._25b6;
            this.Right_pointing.Label = "Right_pointing";
            this.Right_pointing.Name = "Right_pointing";
            this.Right_pointing.ShowImage = true;
            this.Right_pointing.ShowLabel = false;
            this.Right_pointing.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Right_pointing_Click);
            // 
            // Red_book
            // 
            this.Red_book.Image = global::emoji.Properties.Resources._1f4d5;
            this.Red_book.Label = "Red_book";
            this.Red_book.Name = "Red_book";
            this.Red_book.ShowImage = true;
            this.Red_book.ShowLabel = false;
            this.Red_book.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Red_book_Click);
            // 
            // Orange_book
            // 
            this.Orange_book.Image = global::emoji.Properties.Resources._1f4d9;
            this.Orange_book.Label = "Orange_book";
            this.Orange_book.Name = "Orange_book";
            this.Orange_book.ShowImage = true;
            this.Orange_book.ShowLabel = false;
            this.Orange_book.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Orange_book_Click);
            // 
            // mega
            // 
            this.mega.Image = global::emoji.Properties.Resources._1f4e3;
            this.mega.Label = "mega";
            this.mega.Name = "mega";
            this.mega.ShowImage = true;
            this.mega.ShowLabel = false;
            this.mega.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.mega_Click);
            // 
            // loudspeaker
            // 
            this.loudspeaker.Image = global::emoji.Properties.Resources._1f4e2;
            this.loudspeaker.Label = "loudspeaker";
            this.loudspeaker.Name = "loudspeaker";
            this.loudspeaker.ShowImage = true;
            this.loudspeaker.ShowLabel = false;
            this.loudspeaker.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.loudspeaker_Click);
            // 
            // rose
            // 
            this.rose.Image = global::emoji.Properties.Resources._1f339;
            this.rose.Label = "rose";
            this.rose.Name = "rose";
            this.rose.ShowImage = true;
            this.rose.ShowLabel = false;
            this.rose.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.rose_Click);
            // 
            // hibiscus
            // 
            this.hibiscus.Image = global::emoji.Properties.Resources._1f33a;
            this.hibiscus.Label = "hibiscus";
            this.hibiscus.Name = "hibiscus";
            this.hibiscus.ShowImage = true;
            this.hibiscus.ShowLabel = false;
            this.hibiscus.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.hibiscus_Click);
            // 
            // blossom
            // 
            this.blossom.Image = global::emoji.Properties.Resources._1f33c;
            this.blossom.Label = "blossom";
            this.blossom.Name = "blossom";
            this.blossom.ShowImage = true;
            this.blossom.ShowLabel = false;
            this.blossom.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.blossom_Click);
            // 
            // cherry_blossom
            // 
            this.cherry_blossom.Image = global::emoji.Properties.Resources._1f338;
            this.cherry_blossom.Label = "cherry_blossom";
            this.cherry_blossom.Name = "cherry_blossom";
            this.cherry_blossom.ShowImage = true;
            this.cherry_blossom.ShowLabel = false;
            this.cherry_blossom.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cherry_blossom_Click);
            // 
            // tulip
            // 
            this.tulip.Image = global::emoji.Properties.Resources._1f337;
            this.tulip.Label = "tulip";
            this.tulip.Name = "tulip";
            this.tulip.ShowImage = true;
            this.tulip.ShowLabel = false;
            this.tulip.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.tulip_Click);
            // 
            // maple_leaf
            // 
            this.maple_leaf.Image = global::emoji.Properties.Resources._1f341;
            this.maple_leaf.Label = "maple_leaf";
            this.maple_leaf.Name = "maple_leaf";
            this.maple_leaf.ShowImage = true;
            this.maple_leaf.ShowLabel = false;
            this.maple_leaf.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.maple_leaf_Click);
            // 
            // fallen_leaf
            // 
            this.fallen_leaf.Image = global::emoji.Properties.Resources._1f342;
            this.fallen_leaf.Label = "fallen_leaf";
            this.fallen_leaf.Name = "fallen_leaf";
            this.fallen_leaf.ShowImage = true;
            this.fallen_leaf.ShowLabel = false;
            this.fallen_leaf.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.fallen_leaf_Click);
            // 
            // shamrock
            // 
            this.shamrock.Image = global::emoji.Properties.Resources._1f340;
            this.shamrock.Label = "shamrock";
            this.shamrock.Name = "shamrock";
            this.shamrock.ShowImage = true;
            this.shamrock.ShowLabel = false;
            this.shamrock.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.shamrock_Click);
            // 
            // point_up
            // 
            this.point_up.Image = global::emoji.Properties.Resources._1f446;
            this.point_up.Label = "point_up";
            this.point_up.Name = "point_up";
            this.point_up.ShowImage = true;
            this.point_up.ShowLabel = false;
            this.point_up.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.point_up_Click);
            // 
            // point_down
            // 
            this.point_down.Image = global::emoji.Properties.Resources._1f447;
            this.point_down.Label = "point_down";
            this.point_down.Name = "point_down";
            this.point_down.ShowImage = true;
            this.point_down.ShowLabel = false;
            this.point_down.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.point_down_Click);
            // 
            // point_left
            // 
            this.point_left.Image = global::emoji.Properties.Resources._1f448;
            this.point_left.Label = "point_left";
            this.point_left.Name = "point_left";
            this.point_left.ShowImage = true;
            this.point_left.ShowLabel = false;
            this.point_left.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.point_left_Click);
            // 
            // point_right
            // 
            this.point_right.Image = global::emoji.Properties.Resources._1f449;
            this.point_right.Label = "point_right";
            this.point_right.Name = "point_right";
            this.point_right.ShowImage = true;
            this.point_right.ShowLabel = false;
            this.point_right.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.point_right_Click);
            // 
            // pray
            // 
            this.pray.Image = global::emoji.Properties.Resources._1f64f;
            this.pray.Label = "pray";
            this.pray.Name = "pray";
            this.pray.ShowImage = true;
            this.pray.ShowLabel = false;
            this.pray.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.pray_Click);
            // 
            // writing_hand
            // 
            this.writing_hand.Image = global::emoji.Properties.Resources._270d;
            this.writing_hand.Label = "writing_hand";
            this.writing_hand.Name = "writing_hand";
            this.writing_hand.ShowImage = true;
            this.writing_hand.ShowLabel = false;
            this.writing_hand.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writing_hand_Click);
            // 
            // moon
            // 
            this.moon.Image = global::emoji.Properties.Resources._1f312;
            this.moon.Label = "moon";
            this.moon.Name = "moon";
            this.moon.ShowImage = true;
            this.moon.ShowLabel = false;
            this.moon.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.moon_Click);
            // 
            // red_circle
            // 
            this.red_circle.Image = global::emoji.Properties.Resources._1f534;
            this.red_circle.Label = "red_circle";
            this.red_circle.Name = "red_circle";
            this.red_circle.ShowImage = true;
            this.red_circle.ShowLabel = false;
            this.red_circle.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.red_circle_Click);
            // 
            // blue_circle
            // 
            this.blue_circle.Image = global::emoji.Properties.Resources._1f535;
            this.blue_circle.Label = "blue_circle";
            this.blue_circle.Name = "blue_circle";
            this.blue_circle.ShowImage = true;
            this.blue_circle.ShowLabel = false;
            this.blue_circle.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.blue_circle_Click);
            // 
            // small_orange_diamond
            // 
            this.small_orange_diamond.Image = global::emoji.Properties.Resources._1f538;
            this.small_orange_diamond.Label = "small_orange_diamond";
            this.small_orange_diamond.Name = "small_orange_diamond";
            this.small_orange_diamond.ShowImage = true;
            this.small_orange_diamond.ShowLabel = false;
            this.small_orange_diamond.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.small_orange_diamond_Click);
            // 
            // small_blue_diamond
            // 
            this.small_blue_diamond.Image = global::emoji.Properties.Resources._1f539;
            this.small_blue_diamond.Label = "small_blue_diamond";
            this.small_blue_diamond.Name = "small_blue_diamond";
            this.small_blue_diamond.ShowImage = true;
            this.small_blue_diamond.ShowLabel = false;
            this.small_blue_diamond.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.small_blue_diamond_Click);
            // 
            // large_orange_diamond
            // 
            this.large_orange_diamond.Image = global::emoji.Properties.Resources._1f536;
            this.large_orange_diamond.Label = "large_orange_diamond";
            this.large_orange_diamond.Name = "large_orange_diamond";
            this.large_orange_diamond.ShowImage = true;
            this.large_orange_diamond.ShowLabel = false;
            this.large_orange_diamond.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.large_orange_diamond_Click);
            // 
            // large_blue_diamond
            // 
            this.large_blue_diamond.Image = global::emoji.Properties.Resources._1f537;
            this.large_blue_diamond.Label = "large_blue_diamond";
            this.large_blue_diamond.Name = "large_blue_diamond";
            this.large_blue_diamond.ShowImage = true;
            this.large_blue_diamond.ShowLabel = false;
            this.large_blue_diamond.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.large_blue_diamond_Click);
            // 
            // black_circle
            // 
            this.black_circle.Image = global::emoji.Properties.Resources._26ab;
            this.black_circle.Label = "black_circle";
            this.black_circle.Name = "black_circle";
            this.black_circle.ShowImage = true;
            this.black_circle.ShowLabel = false;
            this.black_circle.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.black_circle_Click);
            // 
            // white_circle
            // 
            this.white_circle.Image = global::emoji.Properties.Resources._26aa;
            this.white_circle.Label = "white_circle";
            this.white_circle.Name = "white_circle";
            this.white_circle.ShowImage = true;
            this.white_circle.ShowLabel = false;
            this.white_circle.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.white_circle_Click);
            // 
            // black_medium_square
            // 
            this.black_medium_square.Image = global::emoji.Properties.Resources._25fc;
            this.black_medium_square.Label = "black_medium_square";
            this.black_medium_square.Name = "black_medium_square";
            this.black_medium_square.ShowImage = true;
            this.black_medium_square.ShowLabel = false;
            this.black_medium_square.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.black_medium_square_Click);
            // 
            // white_medium_square
            // 
            this.white_medium_square.Image = global::emoji.Properties.Resources._2b1c;
            this.white_medium_square.Label = "white_medium_square";
            this.white_medium_square.Name = "white_medium_square";
            this.white_medium_square.ShowImage = true;
            this.white_medium_square.ShowLabel = false;
            this.white_medium_square.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.white_medium_square_Click);
            // 
            // black_medium_small_square
            // 
            this.black_medium_small_square.Image = global::emoji.Properties.Resources._25fe;
            this.black_medium_small_square.Label = "black_medium_small_square";
            this.black_medium_small_square.Name = "black_medium_small_square";
            this.black_medium_small_square.ShowImage = true;
            this.black_medium_small_square.ShowLabel = false;
            this.black_medium_small_square.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.black_medium_small_square_Click);
            // 
            // white_medium_small_square
            // 
            this.white_medium_small_square.Image = global::emoji.Properties.Resources._25fd;
            this.white_medium_small_square.Label = "white_medium_small_square";
            this.white_medium_small_square.Name = "white_medium_small_square";
            this.white_medium_small_square.ShowImage = true;
            this.white_medium_small_square.ShowLabel = false;
            this.white_medium_small_square.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.white_medium_small_square_Click);
            // 
            // black_small_square
            // 
            this.black_small_square.Image = global::emoji.Properties.Resources._25aa;
            this.black_small_square.Label = "black_small_square";
            this.black_small_square.Name = "black_small_square";
            this.black_small_square.ShowImage = true;
            this.black_small_square.ShowLabel = false;
            this.black_small_square.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.black_small_square_Click);
            // 
            // white_small_square
            // 
            this.white_small_square.Image = global::emoji.Properties.Resources._25ab;
            this.white_small_square.Label = "white_small_square";
            this.white_small_square.Name = "white_small_square";
            this.white_small_square.ShowImage = true;
            this.white_small_square.ShowLabel = false;
            this.white_small_square.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.white_small_square_Click);
            // 
            // black_checkbox
            // 
            this.black_checkbox.Image = global::emoji.Properties.Resources._2611;
            this.black_checkbox.Label = "black_checkbox";
            this.black_checkbox.Name = "black_checkbox";
            this.black_checkbox.ShowImage = true;
            this.black_checkbox.ShowLabel = false;
            this.black_checkbox.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.black_checkbox_Click);
            // 
            // green_checkbox
            // 
            this.green_checkbox.Image = global::emoji.Properties.Resources._2705;
            this.green_checkbox.Label = "green_checkbox";
            this.green_checkbox.Name = "green_checkbox";
            this.green_checkbox.ShowImage = true;
            this.green_checkbox.ShowLabel = false;
            this.green_checkbox.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.green_checkbox_Click);
            // 
            // down_pointing
            // 
            this.down_pointing.Image = global::emoji.Properties.Resources._1f53d;
            this.down_pointing.Label = "down_pointing";
            this.down_pointing.Name = "down_pointing";
            this.down_pointing.ShowImage = true;
            this.down_pointing.ShowLabel = false;
            this.down_pointing.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.down_pointing_Click);
            // 
            // up_pointing
            // 
            this.up_pointing.Image = global::emoji.Properties.Resources._1f53c;
            this.up_pointing.Label = "up_pointing";
            this.up_pointing.Name = "up_pointing";
            this.up_pointing.ShowImage = true;
            this.up_pointing.ShowLabel = false;
            this.up_pointing.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.up_pointing_Click);
            // 
            // Ribbon
            // 
            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.emoji);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
            this.emoji.ResumeLayout(false);
            this.emoji.PerformLayout();
            this.emoji_group.ResumeLayout(false);
            this.emoji_group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab emoji;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup emoji_group;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton No1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton No2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton No3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton No4;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton No5;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton No6;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton No7;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton No8;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton No9;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton No10;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Red_book;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Orange_book;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton loudspeaker;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton mega;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton hibiscus;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton blossom;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton pray;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton moon;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton tulip;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton cherry_blossom;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton rose;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton shamrock;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton maple_leaf;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton fallen_leaf;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton point_up;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton point_down;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton point_left;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton point_right;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton red_circle;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton small_orange_diamond;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton small_blue_diamond;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton black_medium_square;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton white_medium_square;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton black_small_square;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton white_small_square;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Right_pointing;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Left_pointing;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton white_medium_small_square;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton black_medium_small_square;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton writing_hand;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton black_checkbox;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton green_checkbox;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton blue_circle;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton large_orange_diamond;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton large_blue_diamond;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton white_circle;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton black_circle;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton down_pointing;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton up_pointing;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon Ribbon
        {
            get { return this.GetRibbon<Ribbon>(); }
        }
    }
}
