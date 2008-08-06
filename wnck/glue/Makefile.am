lib_LTLIBRARIES = $(TARGET)

if ENABLE_WNCK
TARGET = libwncksharpglue-2.la
else
TARGET = 
endif

libwncksharpglue_2_la_SOURCES = # empty

nodist_libwncksharpglue_2_la_SOURCES = generated.c

libwncksharpglue_2_la_LDFLAGS = -module -avoid-version -no-undefined

libwncksharpglue_2_la_LIBADD = $(WNCK_LIBS)

INCLUDES = $(WNCK_CFLAGS) -DWNCK_I_KNOW_THIS_IS_UNSTABLE -I$(top_srcdir)

libwncksharpglue.dll: $(libwncksharpglue_2_la_OBJECTS) libwncksharpglue.rc libwncksharpglue.def
	./build-dll libwncksharpglue-2 $(VERSION)

CLEANFILES = lib*.a lib*.dll

