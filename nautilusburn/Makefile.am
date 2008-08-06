SUBDIRS= . glue

if ENABLE_NAUTILUSBURN
pkg = nautilusburn
pkgversion = 2.20
pkgconfigdir = $(libdir)/pkgconfig
pkgconfig_DATA = nautilusburn-sharp.pc
else
pkg = 
pkgversion = 
endif

API_VERSION = 2.20.0.0
INCLUDE_API =
METADATA = metadata
references =
glue_args = --glue-includes=nautilus-burn.h --gluelib-name=nautilusburnsharpglue-2 --glue-filename=glue/generated.c

sources =

customs =

add_dist = nautilusburn-sharp.pc.in nautilusburn-sharp.dll.config.in

include ../Makefile.include

