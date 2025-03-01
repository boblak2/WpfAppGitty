using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Callculator;
using Langy;

namespace WpfAppGitty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Comment 1
            //Comment 2a
            //Comment 3 - again
            //dev1
            //dev2
            //master1
            //master2
            //Stuff
            //Burek branch
            //Burek branch2
            //Burek branch3
            //From burek branch
            //Stash 2
            //stash dev

            Test007 obj = new();
            obj.Id = 1;
            obj.Name = "bob";
            obj.Age = 40;

            var per = new Test007()
            {
                Id = 2,
                Name = "slim",
                Age = 36
            };

            Test007? bob = new Bob();
            bob.Name = "bob es mi nombre";
            //bob.IsClimb = true;
            if (bob is Bob b)
            {
                b.IsClimb = true;
                var v = b.BobJeVelik();
            }


            obj.Drink();
            per.Drink();
            bob?.Drink();

            string ime = "slim";
            ime.NaVeliko();
        }

        private void Test()
        {
            //from remoteL
            //stash new

            //Stash bond
            //Stash1
            //Test Pr
            //rv
        }

        private void TestMan()
        {
            //New version stuff
        }

        private void TestPr()
        {
            //cheange1
            //cheange2
            //cheange3
            int res = Class1.Add(3);
        }

    }
}
