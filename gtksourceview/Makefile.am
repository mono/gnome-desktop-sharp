LIBRARY_NAME=	gtksourceview2-sharp
LIBRARY=	$(LIBRARY_NAME).dll
APIS=		gtksourceview2-api.xml

ASSEMBLIES=	/pkg:gtk-sharp-2.0

EXTRA_DIST = $(sources) $(customs) Gtk.metadata gtksourceview2-api.raw AssemblyInfo.cs.in

DISTCLEANFILES = AssemblyInfo.cs

noinst_DATA = gtksourceview2-sharp.dll

apidir = $(gtksharp_prefix)/share/gapi-2.0
api_DATA = gtksourceview2-api.xml

all: $(LIBRARY)

gtksourceview2-api.xml:
	cp $(srcdir)/gtksourceview2-api.raw gtksourceview2-api.xml
	chmod u+w gtksourceview2-api.xml
	$(GAPI_FIXUP) --api=gtksourceview2-api.xml --metadata=$(srcdir)/Gtk.metadata

generated-stamp: $(APIS) $(customs) $(sources) Gtk.metadata
	$(GAPI_CODEGEN) $(GTK_SHARP_CFLAGS) --generate $(APIS) \
	--outdir=generated --customdir=. --assembly-name=gtksourceview2-sharp && touch generated-stamp

sources = \
GtkSourceView.cs

build_sources = $(addprefix $(srcdir)/, $(sources)) AssemblyInfo.cs

customs = \
	SourceBuffer.custom \
	SourceLanguage.custom \
	SourceLanguageManager.custom \
	SourceStyleSchemeManager.custom

build_customs = $(addprefix $(srcdir)/, $(customs))

gtk-sharp.snk: $(top_srcdir)/gtk-sharp.snk
	cp $(top_srcdir)/gtk-sharp.snk .

$(LIBRARY): generated-stamp $(build_sources) gtk-sharp.snk
	$(CSC) /unsafe /target:library $(ASSEMBLIES) \
	generated/*.cs $(build_sources) -out:$(LIBRARY)

CLEANFILES = $(LIBRARY) generated/*.cs generated-stamp gtksourceview2-api.xml gtk-sharp.snk

install-data-local:
	echo "$(GACUTIL) /i $(LIBRARY) /f $(GACUTIL_FLAGS)";  \
	$(GACUTIL) /i $(LIBRARY) /f $(GACUTIL_FLAGS) || exit 1;

uninstall-local:
	echo "$(GACUTIL) /u $(LIBRARY_NAME) $(GACUTIL_FLAGS)"; \
	$(GACUTIL) /u $(LIBRARY_NAME) $(GACUTIL_FLAGS) || exit 1;
