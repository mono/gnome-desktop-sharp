lib_LTLIBRARIES = $(TARGET)

if ENABLE_GTKSOURCEVIEW
TARGET = libgtksourceview2sharpglue-2.la
else
TARGET = 
endif

libgtksourceview2sharpglue_2_la_SOURCES = # empty

nodist_libgtksourceview2sharpglue_2_la_SOURCES = generated.c

libgtksourceview2sharpglue_2_la_LDFLAGS = -module -avoid-version -no-undefined

libgtksourceview2sharpglue_2_la_LIBADD = $(GTKSOURCEVIEW_LIBS)

INCLUDES = $(GTKSOURCEVIEW_CFLAGS) -I$(top_srcdir)

libgtksourceview2sharpglue.dll: $(libgtksourceview2sharpglue_2_la_OBJECTS) libgtksourceview2sharpglue.rc libgtksourceview2sharpglue.def
	./build-dll libgtksourceview2sharpglue-2 $(VERSION)

CLEANFILES = lib*.a lib*.dll

