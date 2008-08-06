lib_LTLIBRARIES = $(TARGET)

if ENABLE_GTKHTML
TARGET = libgtkhtmlsharpglue-2.la
else
TARGET = 
endif

libgtkhtmlsharpglue_2_la_SOURCES = # empty

nodist_libgtkhtmlsharpglue_2_la_SOURCES = generated.c

libgtkhtmlsharpglue_2_la_LDFLAGS = -module -avoid-version -no-undefined

libgtkhtmlsharpglue_2_la_LIBADD = $(GTKHTML_LIBS)

INCLUDES = $(GTKHTML_CFLAGS) -I$(top_srcdir)

libgtkhtmlsharpglue.dll: $(libgtkhtmlsharpglue_2_la_OBJECTS) libgtkhtmlsharpglue.rc libgtkhtmlsharpglue.def
	./build-dll libgtkhtmlsharpglue-2 $(VERSION)

CLEANFILES = lib*.a lib*.dll

