# All: Generates the zipfile to deploy in MAPS
all:
ifndef project
	$(error You must define project=<projectname>)
endif
	$(MAKE) $(project)/codep.desc
	$(MAKE) output/$(project).zip

# capture_test: Opens a browser window to show current capture interface
capture_test: prepare
ifndef project
	$(error You must define project=<projectname>)
endif
	xdg-open tmp/new_coresp.html

# view_test: Opens a browser window to show current display interface
view_test: prepare
ifndef project
	$(error You must define project=<projectname>)
endif
	xdg-open tmp/view_list_coresp.html

# clean: removes all project intermediate-files
clean:
ifdef project # BEGIN: DELETE PROJECT FILES IF DEFINED
ifneq ("$(wildcard $(project)/codep.desc)","")
	rm $(project)/codep.desc
endif
ifneq ("$(wildcard output/$(project).zip)","")
	rm output/$(project).zip
endif
endif # END: DELETE PROJECT FILES
ifneq ("$(wildcard tmp/*)","")
	rm -r $(wildcard tmp/*)
endif

# $(project)/codep.desc: Compiles the Protocol Buffer definition
$(project)/codep.desc:
	$(info "Compiling protocol buffer definition for $(project).")
ifeq ("$(wildcard $(project)/cdp.proto)","")
	$(error	"Protocol buffer definition not found.")
endif
	protoc $(project)/cdp.proto -o $(project)/codep.desc

# prepare: Compiles all the required files for the project in tmp
prepare:
ifndef project
	$(error You must define project=<projectname>)
endif
ifeq ("$(wildcard tmp/)","")
	mkdir tmp
endif
	cp -r $(project)/* tmp/
ifeq ("$(wildcard output/)","")
	mkdir output
endif
ifneq ("$(wildcard $(project)/source.config)","")
	cd resources; for RESOURCE in `cat ../$(project)/source.config`; do cp -vr --parents $$RESOURCE ../tmp; done
endif

# output/$(project).zip: Generates the zipfile to deploy
output/$(project).zip: prepare
	cd tmp; zip -r9 ../output/$(project).zip *
