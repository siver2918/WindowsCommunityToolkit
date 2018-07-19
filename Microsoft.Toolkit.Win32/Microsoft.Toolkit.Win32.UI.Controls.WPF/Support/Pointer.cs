namespace Microsoft.Toolkit.Win32.UI.Controls.WPF
{
    /// <summary>
    /// <see cref="global::Windows.UI.Xaml.Input.Pointer"/>
    /// </summary>
    public class Pointer
    {
        internal global::Windows.UI.Xaml.Input.Pointer UwpInstance { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pointer"/> class, a
        /// Wpf-enabled wrapper for <see cref="global::Windows.UI.Xaml.Input.Pointer"/>
        /// </summary>
        public Pointer(global::Windows.UI.Xaml.Input.Pointer instance)
        {
            this.UwpInstance = instance;
        }

        /// <summary>
        /// Gets a value indicating whether <see cref="global::Windows.UI.Xaml.Input.Pointer.IsInContact"/>
        /// </summary>
        public bool IsInContact
        {
            get => UwpInstance.IsInContact;
        }

        /// <summary>
        /// Gets a value indicating whether <see cref="global::Windows.UI.Xaml.Input.Pointer.IsInRange"/>
        /// </summary>
        public bool IsInRange
        {
            get => UwpInstance.IsInRange;
        }

        /// <summary>
        /// Gets <see cref="global::Windows.UI.Xaml.Input.Pointer.PointerDeviceType"/>
        /// </summary>
        public global::Windows.Devices.Input.PointerDeviceType PointerDeviceType
        {
            get => UwpInstance.PointerDeviceType;
        }

        /// <summary>
        /// Gets <see cref="global::Windows.UI.Xaml.Input.Pointer.PointerId"/>
        /// </summary>
        public uint PointerId
        {
            get => UwpInstance.PointerId;
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="global::Windows.UI.Xaml.Input.Pointer"/> to <see cref="Microsoft.Toolkit.Win32.UI.Controls.WPF.Pointer"/>.
        /// </summary>
        /// <param name="args">The <see cref="global::Windows.UI.Xaml.Input.Pointer"/> instance containing the event data.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Pointer(
            global::Windows.UI.Xaml.Input.Pointer args)
        {
            return FromPointer(args);
        }

        /// <summary>
        /// Creates a <see cref="Pointer"/> from <see cref="global::Windows.UI.Xaml.Input.Pointer"/>.
        /// </summary>
        /// <param name="args">The <see cref="global::Windows.UI.Xaml.Input.Pointer"/> instance containing the event data.</param>
        /// <returns><see cref="Pointer"/></returns>
        public static Pointer FromPointer(global::Windows.UI.Xaml.Input.Pointer args)
        {
            return new Pointer(args);
        }
    }
}