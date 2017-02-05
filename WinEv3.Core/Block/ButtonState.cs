﻿namespace WinEv3.Core.Block
{
    /// <summary>
    /// ButtonState on the face of the LEGO EV3 brick
    /// </summary>
    public sealed class ButtonState
    {
        /// <summary>
        /// Up button
        /// </summary>
        public bool Up { get; set; }
        /// <summary>
        ///  Down button
        /// </summary>
        public bool Down { get; set; }
        /// <summary>
        /// Left button
        /// </summary>
        public bool Left { get; set; }
        /// <summary>
        /// Right button
        /// </summary>
        public bool Right { get; set; }
        /// <summary>
        ///  Back button
        /// </summary>
        public bool Back { get; set; }
        /// <summary>
        /// Enter button
        /// </summary>
        public bool Enter { get; set; }
    }
}