using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace RevitEasy.WPF.Behaviors
{
    public class RevitFormBehavior
    {
        private static bool isDragging = false;
        private static Point startPoint;

        #region Window Dragging

        public static void Register(Window window)
        {
            // Register window events for dragging
            window.MouseDown += Window_MouseDown;
            window.MouseMove += Window_MouseMove;
            window.MouseUp += Window_MouseUp;

            // Register close, minimize, and restore button events
            Button btnClose = FindCloseButton(window);
            Button btnMinimize = FindMinimizeButton(window);
            Button btnRestore = FindRestoreButton(window);

            if (btnClose != null)
            {
                btnClose.Click += Btn_CloseClick;
            }

            if (btnMinimize != null)
            {
                btnMinimize.Click += Btn_MinimizeClick;
            }

            if (btnRestore != null)
            {
                btnRestore.Click += Btn_RestoreClick;
            }
        }

        private static void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Handle mouse down event for dragging
            if (e.ChangedButton == MouseButton.Left)
            {
                isDragging = true;
                startPoint = e.GetPosition(sender as Window);
            }
        }

        private static void Window_MouseMove(object sender, MouseEventArgs e)
        {
            // Handle mouse move event for dragging
            if (isDragging && e.LeftButton == MouseButtonState.Pressed)
            {
                Window window = sender as Window;
                Point currentPosition = e.GetPosition(window);

                double deltaX = currentPosition.X - startPoint.X;
                double deltaY = currentPosition.Y - startPoint.Y;

                window.Left += deltaX;
                window.Top += deltaY;
            }
        }

        private static void Window_MouseUp(object sender, MouseButtonEventArgs e)
        {
            // Handle mouse up event for dragging
            if (e.ChangedButton == MouseButton.Left)
            {
                isDragging = false;
            }
        }

        #endregion

        #region Window Buttons

        private static void Btn_CloseClick(object sender, RoutedEventArgs e)
        {
            // Handle close button click
            Window window = FindParentWindow(sender as FrameworkElement);
            if (window != null)
            {
                window.Close();
            }
        }

        private static void Btn_MinimizeClick(object sender, RoutedEventArgs e)
        {
            // Handle minimize button click
            Window window = FindParentWindow(sender as FrameworkElement);
            if (window != null)
            {
                window.WindowState = WindowState.Minimized;
            }
        }

        private static void Btn_RestoreClick(object sender, RoutedEventArgs e)
        {
            // Handle restore button click
            Window window = FindParentWindow(sender as FrameworkElement);
            if (window != null)
            {
                if (window.WindowState == WindowState.Maximized)
                {
                    window.WindowState = WindowState.Normal;
                }
                else
                {
                    window.WindowState = WindowState.Maximized;
                }
            }
        }

        #endregion

        #region Helper Methods

        private static Button FindCloseButton(Window window)
        {
            return window.FindName("Btn_Close") as Button;
        }

        private static Button FindMinimizeButton(Window window)
        {
            return window.FindName("Btn_Minimize") as Button;
        }

        private static Button FindRestoreButton(Window window)
        {
            return window.FindName("Btn_Restore") as Button;
        }

        private static Window FindParentWindow(FrameworkElement element)
        {
            Window window = null;
            DependencyObject parent = VisualTreeHelper.GetParent(element);

            while (parent != null && !(parent is Window))
            {
                parent = VisualTreeHelper.GetParent(parent);
            }

            if (parent is Window)
            {
                window = parent as Window;
            }

            return window;
        }

        #endregion
    }
}
