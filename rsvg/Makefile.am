if ENABLE_RSVG
pkg = rsvg2
pkgversion = 2.0
pkgconfigdir = $(libdir)/pkgconfig
pkgconfig_DATA = rsvg2-sharp-2.0.pc
else
pkg = 
pkgversion = 
endif

API_VERSION = 2.18.0.0
INCLUDE_API =
METADATA = Rsvg.metadata
references =

sources =			\
	Tool.cs

customs = 			\
	Handle.custom		\
	Pixbuf.custom

add_dist = rsvg2-sharp-2.0.pc.in rsvg2-sharp.dll.config.in

include ../Makefile.include

