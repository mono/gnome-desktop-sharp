if ENABLE_GTKHTML
pkg = gtkhtml
pkgversion = 3.14
pkgconfigdir = $(libdir)/pkgconfig
pkgconfig_DATA = gtkhtml-sharp-3.14.pc
else
pkg = 
endif

INCLUDE_API =
METADATA = metadata
SYMBOLS =
references =

sources =

customs =			\
	HTML.custom		\
	HTMLStream.custom	

add_dist = gtkhtml-sharp-3.14.pc.in

include ../Makefile.include

