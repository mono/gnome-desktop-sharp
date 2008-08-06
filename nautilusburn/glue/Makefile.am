lib_LTLIBRARIES = $(TARGET)

if ENABLE_NAUTILUSBURN
TARGET = libnautilusburnsharpglue-2.la
else
TARGET = 
endif

libnautilusburnsharpglue_2_la_SOURCES = # empty

nodist_libnautilusburnsharpglue_2_la_SOURCES = generated.c

libnautilusburnsharpglue_2_la_LDFLAGS = -module -avoid-version -no-undefined

libnautilusburnsharpglue_2_la_LIBADD = $(NAUTILUSBURN_LIBS)

INCLUDES = $(NAUTILUSBURN_CFLAGS) -I$(top_srcdir)

libnautilusburnsharpglue.dll: $(libnautilusburnsharpglue_2_la_OBJECTS) libnautilusburnsharpglue.rc libnautilusburnsharpglue.def
	./build-dll libnautilusburnsharpglue-2 $(VERSION)

CLEANFILES = lib*.a lib*.dll

