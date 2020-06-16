using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Cardview.RNCardview
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNCardviewModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNCardviewModule"/>.
        /// </summary>
        internal RNCardviewModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNCardview";
            }
        }
    }
}
