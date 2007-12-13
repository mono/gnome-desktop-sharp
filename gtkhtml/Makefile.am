if ENABLE_GTKHTML
pkg = gtkhtml
pkgversion = 3.14
pkgconfigdir = $(libdir)/pkgconfig
pkgconfig_DATA = gtkhtml-sharp-3.14.pc
else
pkg = 
pkgversion = 
endif

API_VERSION=3.16.0.0
INCLUDE_API =
METADATA = metadata
references =

sources =

customs =			\
	HTML.custom		\
	HTMLStream.custom	

add_dist = gtkhtml-sharp-3.14.pc.in gtkhtml-sharp.dll.config.in

include ../Makefile.include

