// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using UnityEngine.EventSystems;

namespace Microsoft.MixedReality.Toolkit.Input
{
    /// <summary>
    /// Interface to implement to react to focus enter/exit.
    /// </summary>
    /// <remarks>
    /// <para>The events on this interface are related to those of <see cref="IMixedRealityFocusChangedHandler"/>, whose event have
    /// a known ordering with this interface:</para>
    /// <para>IMixedRealityFocusChangedHandler::OnBeforeFocusChange</para>
    /// <para>IMixedRealityFocusHandler::OnFocusEnter</para>
    /// <para>IMixedRealityFocusHandler::OnFocusExit</para>
    /// <para>IMixedRealityFocusChangedHandler::OnFocusChanged</para>
    /// <para>Because these two interfaces are different, consumers must be wary about having nested
    /// hierarchies where some game objects will implement both interfaces, and more deeply nested
    /// object within the same parent-child chain that implement a single one of these - such
    /// a presence can lead to scenarios where one interface is invoked on the child object, and then
    /// the other interface is invoked on the parent object (thus, the parent would "miss" getting
    /// the event that the child had already processed).</para>
    /// </remarks>
    public interface IMixedRealityFocusHandler : IEventSystemHandler
    {
        /// <summary>
        /// The Focus Enter event is raised on this <see href="https://docs.unity3d.com/ScriptReference/GameObject.html">GameObject</see> whenever a <see cref="Microsoft.MixedReality.Toolkit.Input.IMixedRealityPointer"/>'s focus enters this <see href="https://docs.unity3d.com/ScriptReference/GameObject.html">GameObject</see>'s <see href="https://docs.unity3d.com/ScriptReference/Collider.html">Collider</see>.
        /// </summary>
        void OnFocusEnter(FocusEventData eventData);

        /// <summary>
        /// The Focus Exit event is raised on this <see href="https://docs.unity3d.com/ScriptReference/GameObject.html">GameObject</see> whenever a <see cref="Microsoft.MixedReality.Toolkit.Input.IMixedRealityPointer"/>'s focus leaves this <see href="https://docs.unity3d.com/ScriptReference/GameObject.html">GameObject</see>'s <see href="https://docs.unity3d.com/ScriptReference/Collider.html">Collider</see>.
        /// </summary>
        void OnFocusExit(FocusEventData eventData);
    }
}
