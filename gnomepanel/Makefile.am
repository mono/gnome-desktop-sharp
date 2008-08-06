SUBDIRS = . glue

if ENABLE_GNOME_PANEL
pkg = gnome-panel
pkgversion = 2.24
pkgconfigdir = $(libdir)/pkgconfig
pkgconfig_DATA = gnome-panel-sharp-2.24.pc
else
pkg = 
pkgversion = 
endif

API_VERSION=2.24.0.0
INCLUDE_API =
METADATA = metadata
references =
glue_args = --glue-includes=panel-applet.h --gluelib-name=gnomepanelsharpglue-2 --glue-filename=glue/generated.c

sources =			\
	PanelAppletFactory.cs

customs =			\
	PanelApplet.custom

add_dist = gnome-panel-sharp-2.24.pc.in gnome-panel-sharp.dll.config.in

include ../Makefile.include

