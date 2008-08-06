SUBDIRS= . glue

pkg = gtksourceview2
pkgconfigdir = $(libdir)/pkgconfig
pkgconfig_DATA = gtksourceview2-sharp.pc
pkgversion = 2.0

API_VERSION = 2.0.0.0
INCLUDE_API =
METADATA = Gtk.metadata
references =
glue_args = --glue-includes=gtksourceview/gtksourceview.h --gluelib-name=gtksourceview2sharpglue-2 --glue-filename=glue/generated.c

sources =			\
	GtkSourceView.cs

customs =					\
	SourceBuffer.custom

add_dist = gtksourceview2-sharp.pc.in gtksourceview2-sharp.dll.config.in

include ../Makefile.include

