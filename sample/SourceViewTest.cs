using System;
using System.IO;
using Gtk;
using GtkSourceView;

class SourceViewTest
{
	static string filename;
	static SourceLanguage language;

	static void Main (string[] args)
	{
		if (args.Length == 0)
			PrintUsage ();
		
		filename = args[0];
		if (!File.Exists (filename)) {
			Console.WriteLine ("File not found: {0}", filename);
			return;
		}
		
		string lang = (args.Length > 1)?  args[1] : "c-sharp";
		language = SourceLanguageManager.Default.GetLanguage (lang);
		if (language == null) {
			Console.WriteLine ("Invalid language ID: {0}", lang);
			return;
		}
		
		if (args.Length > 2)
			PrintUsage ();

		Application.Init ();
		new SourceViewTest ();
		Application.Run ();
	}

	static void PrintUsage ()
	{
		Console.WriteLine ("Usage: SourceViewTest.exe filename [language]");
		Console.WriteLine ("\nAvailable languages:");
		foreach (string lang in SourceLanguageManager.Default.LanguageIds) {
			SourceLanguage sl = SourceLanguageManager.Default.GetLanguage (lang);
			string mimeTypes = string.Join (", ", sl.MimeTypes);
			Console.WriteLine ("\t{0} ({1})", lang, mimeTypes);
		}
		
		Console.WriteLine ("\nAvailable styles:");
		foreach (string style in SourceStyleSchemeManager.Default.SchemeIds)
			Console.WriteLine ("\t{0}", style);
		
		Console.WriteLine ("\nLanguage search paths:");
		foreach (string searchPath in SourceLanguageManager.Default.SearchPath)
			Console.WriteLine ("\t{0}", searchPath);
		
		Console.WriteLine ("\nStyle scheme search paths:");
		foreach (string searchPath in SourceStyleSchemeManager.Default.SearchPath)
			Console.WriteLine ("\t{0}", searchPath);
			
		Console.WriteLine ();
		Environment.Exit (0);
	}

	SourceViewTest ()
	{
		Window win = new Window ("SourceView test");
		win.SetDefaultSize (600, 400);
		win.WindowPosition = WindowPosition.Center;
		win.DeleteEvent += new DeleteEventHandler (OnWinDelete);
		win.Add (CreateView ());
		win.ShowAll ();
	}

	ScrolledWindow CreateView ()
	{
		ScrolledWindow sw = new ScrolledWindow ();
		SourceView view = new SourceView (CreateBuffer ());
		sw.Add (view);
		return sw;
	}

	SourceBuffer CreateBuffer ()
	{
		SourceBuffer buffer = new SourceBuffer (language);
		buffer.HighlightSyntax = true;
		buffer.HighlightMatchingBrackets = true;
		StreamReader sr = File.OpenText (filename);
		buffer.Text = sr.ReadToEnd ();
		sr.Close ();
		return buffer;
	}

	void OnWinDelete (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}

