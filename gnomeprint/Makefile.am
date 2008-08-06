if ENABLE_GNOME_PRINT
pkg = gnome-print
pkgversion = 2.18
pkgconfigdir = $(libdir)/pkgconfig
pkgconfig_DATA = gnome-print-sharp-2.18.pc
else
pkg = 
pkgversion = 
endif

API_VERSION=2.18.0.0
INCLUDE_API =
METADATA = metadata
references = 

sources =			\
	FontFamily.cs

customs =			\
	Font.custom		\
	Print.custom		\
	PrintContext.custom	\
	PrintDialog.custom	\
	PrintJob.custom

add_dist = gnome-print-sharp-2.18.pc.in gnome-print-sharp.dll.config.in

include ../Makefile.include

