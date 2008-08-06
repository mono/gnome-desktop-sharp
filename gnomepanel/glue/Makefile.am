lib_LTLIBRARIES = $(TARGET)

if ENABLE_GNOME_PANEL
TARGET = libgnomepanelsharpglue-2.la
else
TARGET = 
endif

libgnomepanelsharpglue_2_la_SOURCES = panelapplet.c

nodist_libgnomepanelsharpglue_2_la_SOURCES = generated.c

libgnomepanelsharpglue_2_la_LDFLAGS = -module -avoid-version -no-undefined

libgnomepanelsharpglue_2_la_LIBADD = $(GNOME_PANEL_LIBS)

INCLUDES = $(GNOME_PANEL_CFLAGS) -I$(top_srcdir)

libgnomepanelsharpglue.dll: $(libgnomepanelsharpglue_2_la_OBJECTS) libgnomepanelsharpglue.rc libgnomepanelsharpglue.def
	./build-dll libgnomepanelsharpglue-2 $(VERSION)

CLEANFILES = lib*.a lib*.dll

