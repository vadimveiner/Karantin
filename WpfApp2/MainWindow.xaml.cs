using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Globalization;
using System.Resources;




namespace WpfApp2
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{


		public MainWindow()
		{
			InitializeComponent();
			System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
			timer.Tick += new EventHandler(Timer);
			timer.Interval = new TimeSpan(1);
			timer.Start();
			System.Windows.Threading.DispatcherTimer timer1 = new System.Windows.Threading.DispatcherTimer();
			timer1.Tick += new EventHandler(Timer1);
			timer1.Interval = new TimeSpan(1);
			timer1.Start();
			System.Windows.Threading.DispatcherTimer timer3 = new System.Windows.Threading.DispatcherTimer();
			timer3.Tick += new EventHandler(Timer3);
			timer3.Interval = new TimeSpan(0,0,11);
			timer3.Start();
		}

		private void Timer3(object sender, EventArgs e)
		{
			picture.Visibility = Visibility.Hidden;

		}

			private void Timer(object sender, EventArgs e)
		{
			Random r = new Random();
			int R = r.Next(0, 255);
			int G = r.Next(0, 255);
			int B = r.Next(0, 255);
			int f = r.Next(1, 255);
			RotateTransform alpha = new RotateTransform();
			int Gr1 = 1;
			Gr += 10;
			if (Gr > 1000000000)

				Gr = -10;

			alpha.Angle = Gr;

			CaptchaLabel.RenderTransform = alpha;
			CaptchaLabel.Foreground = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r.Next(1, 255)), Convert.ToByte(r.Next(1, 255)), Convert.ToByte(r.Next(1, 255))));
			if (Gr1 > 1)
				Gr1++; ;

		}
		private void Timer1(object sender, EventArgs e)
		{
			Random r = new Random();
			int R = r.Next(0, 255);
			int G = r.Next(0, 255);
			int B = r.Next(0, 255);
			RotateTransform alpha = new RotateTransform();
			Gr += 10;
			if (Gr > 50000)

				Gr = -10;
			alpha.Angle = Gr;
			CaptchaLabel.RenderTransform = alpha;
			Windoww.Background.RelativeTransform = alpha;
			//Windoww.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r.Next(1, 255)), Convert.ToByte(r.Next(1, 255)), Convert.ToByte(r.Next(1, 255))));

		}
		void xexexe()
		{
			Random random = new Random();
			int x = random.Next(-30, 60);
			int y = random.Next(-30, 10);
			int x1 = 360;
			x1 += 1;
			
			CaptchaB.RenderTransformOrigin = new Point(random.Next(-100, 100), random.Next(-200, 200));
			LoginB.RenderTransformOrigin = new Point(random.Next(-100, 100), random.Next(-200, 200));
			repeatb.RenderTransformOrigin = new Point(random.Next(-100, 100), random.Next(-200, 200));
			PassL.RenderTransformOrigin = new Point(random.Next(-100, 100), random.Next(-200, 200));
			TheEndOfTheWorld.RenderTransformOrigin = new Point(random.Next(-300, 100), random.Next(-400, 300));
			CaptchaLabel.RenderTransformOrigin = new Point(random.Next(-100, 100), random.Next(-200, 200));
			LoginL.RenderTransformOrigin = new Point(random.Next(-100, 100), random.Next(-200, 200));
			repeatbb.RenderTransformOrigin = new Point(random.Next(-100, 100), random.Next(-200, 200));
			PasswordTB.RenderTransformOrigin = new Point(random.Next(-100, 100), random.Next(-200, 200));
			LoginTB.RenderTransformOrigin = new Point(random.Next(-100, 100), random.Next(-200, 200));
			CaptchaTB.RenderTransformOrigin = new Point(random.Next(-100, 100), random.Next(-200, 200));
	

			RotateTransform RotatE = new RotateTransform();
			RotatE.Angle = x1;
			TransformGroup trans = new TransformGroup();
			trans.Children.Add(RotatE);
			LoginB.RenderTransform = trans;
			repeatb.RenderTransform = trans;
			CaptchaB.RenderTransform = trans;
			PassL.RenderTransform = trans;

			CaptchaLabel.RenderTransform = trans;
			LoginL.RenderTransform = trans;
			repeatbb.RenderTransform = trans;
			PasswordTB.RenderTransform = trans;
			LoginTB.RenderTransform = trans;
			CaptchaTB.RenderTransform = trans;
			TheEndOfTheWorld.RenderTransform = trans;
		}

		private void Timer2(object sender, EventArgs e)
		{
			xexexe();
		}
		private void CaptchaButtonClick(object sender, RoutedEventArgs e)
		{
			
			String CaptchaBorders = "";

			CaptchaBorders = "Q,W,E,R,T,Y,U,I,O,P,1,2,3,4,5,6,7,8,9,0q,w,e,r,t,y,u,i,o,p";
			char[] a = { ',' };
			String[] CharArray = CaptchaBorders.Split(a);
			String Before = "";
			string After = "";
			Random Random = new Random();
			for (int i = 0; i < 6; i++)

			{

				After = CharArray[(Random.Next(0, CharArray.Length))];
				Before += After;
			}
			CaptchaLabel.Content = Before;

			Button btn = sender as Button;
			if (btn != null)
			{
				var rotateTransform = btn.RenderTransform as RotateTransform;
				var transform = new RotateTransform(15 + (rotateTransform?.Angle ?? 0));
			}
			

		}
		int Gr = 0;

		private void LoginBClick(object sender, RoutedEventArgs e)
		{
			StreamReader sr = new StreamReader("save.txt");
			string Line, passtxt = "", logtxt = "", Captcha = "";
			while ((Line = sr.ReadLine()) != null)
			{
				int i = 0;
				while (Line[i] != ' ')
				{

					logtxt += Line[i];
					i++;
				}
				i++;
				while (i != Line.Length)
				{
					passtxt += Line[i];
					i++;
				}
				if (LoginTB.Text == logtxt && PasswordTB.Text == passtxt)
				{
					break;
				}
				passtxt = ""; logtxt = ""; Captcha = "";
			}


			if (LoginTB.Text.ToString() == "")
			{
				MessageBox.Show("Enter login");
			}
			if (PasswordTB.Text.ToString() == "")
			{
				MessageBox.Show("Enter password");
			}
			if (CaptchaTB.Text.ToString() != CaptchaLabel.Content.ToString())
			{
				CaptchaTB.Text = "";
				MessageBox.Show("Wrong Captcha");
			}
			if (PasswordTB.Text == passtxt && LoginTB.Text == logtxt)
			{
				logtxt = "";
				passtxt = "";

				if (CaptchaTB.Text.ToString() == CaptchaLabel.Content.ToString())
				{
					MessageBox.Show("Successful authorization");
				}
			}
			else
			{
				MessageBox.Show("Wrong login or password");
				logtxt = "";
				passtxt = "";

			}

		}


		private void jljklj(object sender, MouseEventArgs e)
		{
			int quantity = 50;

			for (int i = 0; i < quantity; i++)
			{
				Window1 win1 = new Window1();
				Window2 win2 = new Window2();
				Window3 win3 = new Window3();
				Window4 win4 = new Window4();
				this.Hide();
				this.Show();
				win1.Show();
				win1.Close();
				win2.Show();
				win2.Close();
				win3.Show();
				win3.Close();
				win4.Show();
				win4.Close();

			}

		}


		private void randomb(object sender, RoutedEventArgs e)
		{

		}

		private void Repeatb_Click(object sender, RoutedEventArgs e)
		{

			int width = 2;
			double height = 0.5;
			Random random = new Random(); ;
			repeatb.Width += width;
			CaptchaB.Width += width;
			CaptchaLabel.Width += width;
			CaptchaB.Width += width;
			CaptchaLabel.Width += width;
			repeatb.Height += height;
			CaptchaB.Height += height;
			CaptchaLabel.Height += height;
			CaptchaB.Height += height;
			CaptchaLabel.Height += height;
			CaptchaTB.Width += width;
			CaptchaTB.Height += height;
			LoginB.Width += width;
			LoginB.Height += height;
			LoginTB.Width += width;
			LoginTB.Height += height;
			PasswordTB.Width += width;
			PasswordTB.Height += height;
			PassL.Width += width;
			PassL.Height += height;
			LoginL.Width += width;
			LoginL.Height += height;
			LoginL.FontSize += 1;
			PassL.FontSize += 1;
		}


		private void repeatbbclick(object sender, RoutedEventArgs e)
		{
			xexexe();
		}
		System.Windows.Threading.DispatcherTimer timer2 = new System.Windows.Threading.DispatcherTimer();
		private void partyDancer(object sender, RoutedEventArgs e)
		{
			TheEndOfTheWorld.Visibility = Visibility.Visible;
			timer2.Tick += new EventHandler(Timer2);
			timer2.Interval = new TimeSpan(1);
			timer2.Start();

			

		}
		private void KonecVeseluxi(object sender, RoutedEventArgs e)
		{
			timer2.Stop();
		}
	
	}
}