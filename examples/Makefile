all:
ifndef project
	$(error You must define project=<projectname>)
endif
	$(MAKE) $(project)/codep.desc
	$(MAKE) output/$(project).zip

test:
ifndef project
	$(error You must define project=<projectname>)
endif
	xdg-open $(project)/new_coresp.html

clean:
ifndef project
	$(error You must define project=<projectname>)
endif
	$(info Removing temporary files.)
ifneq ("$(wildcard tmp/*)","")
	rm -r $(wildcard tmp/*)
endif
	$(info Removing compiled protocol buffer)
ifneq ("$(wildcard $(project)/codep.desc)","")
	rm $(project)/codep.desc
endif
	$(info Removing output zipfile)
ifneq ("$(wildcard output/$(project).zip)","")
	rm output/$(project).zip
endif

$(project)/codep.desc:
	$(info "Compiling protocol buffer definition for $(project).")
ifeq ("$(wildcard $(project)/cdp.proto)","")
	$(error	"Protocol buffer definition not found.")
endif
	protoc $(project)/cdp.proto -o $(project)/codep.desc

output/$(project).zip:
ifeq ("$(wildcard tmp/)","")
	mkdir tmp
endif
	cp -r $(project)/* tmp/
ifeq ("$(wildcard output/)","")
	mkdir output
endif
	cd tmp; zip -r9 ../output/$(project).zip *
