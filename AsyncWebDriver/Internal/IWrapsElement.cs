// Copyright (c) Oleg Zudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// This file is based on or incorporates material from the project Selenium, licensed under the Apache License, Version 2.0. More info in THIRD-PARTY-NOTICES file.

namespace Zu.AsyncWebDriver.Internal
{
    /// <summary>
    ///     Defines the interface through which the user can discover if there is an underlying element to be used.
    /// </summary>
    public interface IWrapsElement
    {
        /// <summary>
        ///     Gets the <see cref="IWebElement" /> wrapped by this object.
        /// </summary>
        IWebElement WrappedElement { get; }
    }
}