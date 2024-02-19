using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Essa
{
    public static class MojeKomendy
    {
        public static readonly RoutedUICommand Zawijaj = new RoutedUICommand("Zawijaj wiersze", "Zawijanie",
            typeof(MojeKomendy),
            new InputGestureCollection()
            {
                new KeyGesture(Key.R, ModifierKeys.Control)
            });

        public static readonly RoutedUICommand Powieksz = new RoutedUICommand("Powiększ tekst", "Powiększanie",
            typeof(MojeKomendy),
            new InputGestureCollection()
            {
                new KeyGesture(Key.P, ModifierKeys.Control)
            });
    }
}