// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void UrlRequestedHandler(object o, UrlRequestedArgs args);

	public class UrlRequestedArgs : GLib.SignalArgs {
		public string Url{
			get {
				return (string) Args[0];
			}
		}

		public Gtk.HTMLStream Handle{
			get {
				return (Gtk.HTMLStream) Args[1];
			}
		}

	}
}
