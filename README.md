# Active Monitoring for Social Programmes (MAPS)

MAPS is the Spanish acronym for Active Monitoring of Social Programmes (Monitoreo Activo de Programas Sociales). This is one of the projects funded by the [World Food Programme Innovation Accelerator](http://innovation.wfp.org/) office in Munich and designed and implemented by WFP El Salvador Country Office.

MAPS helps to capture and track the individual achivements of participants of social programmes. It was designed to be able to work completely offline combining state-of-art NFC technology and a powerful framework that can be used to desing and create any kind of data capture interfaces.

The way that the system works allows the programme designer to capture key outcome indicators in a beneficiary owned smart-card. Both the data and the user interface are fully customizable "on-the-fly". This unique feature allows to design a wide range of user interfaces ranging from simple check-box interfaces to fully interactive graphs.

Once deployed, the programme can be programmed to work offline however when the NFC device connect to the Internet then all the data is uploaded to the cloud and is accesible through a REST API allowing it to connect from any existing data management platform.

This repository includes several data-capture and visualization interfaces currently used in production in El Salvador to track the beneficiaries of the Poverty-Reduction Programmes that WFP is supporting in conjunction with the Goverment.

### What do I need to use MAPS?
To implement MAPS on the field you would need the following combination of Hardware and Software:

1. Secure NFC devices (Currently provided by [FAMOCO](https://www.famoco.com/))
2. NFC Cards ([MIFARE DESFire EV1 8K](https://www.nxp.com/products/identification-and-security/mifare-ics/mifare-desfire/mifare-desfire-ev1-contactless-multi-application-ic:MIFARE_DESFIRE_EV1_8K))
3. Access to the Cloud Management Platform (MAPS Cloud)

However, if you want to develop the capture/visualization interfaces for MAPS you'll only need a web browser, a good text editor and [Google Protocol Buffers](https://developers.google.com/protocol-buffers/docs/downloads).

### Understanding MAPS
Before starting to develop interfaces for MAPS is important to know the current capabilities of the cards used and how the data flows in the whole system.

### The card
The current NFC cards are formatted in a way that they have two data files. The first datafile on the card stores all the beneficiary-related info. The second file is a cyclic record to store a maximum of 76 individual events. Each event has a maximum capacity of 96 bytes.

Google Protocol Buffers is used to define the format to store the data on each event, used "as-is" it's possible to store near 10 (32-bit) numeric or floating-point records for each individual event. Using it with more advanced programing techniques like packing and restricting data ranges it's possible to double or triple the number of indicators by each individual event.

Each NFC card can support different types of events. The cloud management platform is used to define the different types of event that could be recorded under each individual programme.

### The Device
FAMOCO provides NFC-enabled mobile devices that support Secure Access Modules (SAM) to keep safe the keys used by the cards in the system.

When a card is close to one of the devices a custom application reads the beneficiary information and the cyclic record and shows the different event types available depending on the active programme of the device owner.

The custom application reads the data from the card and exposes it through an Javascript API available in an embedded web browser. 

It is possible for each individual event type to define a custom data capture/visualization interface.

### The Cloud
When Internet connectivity is available all the data is syncronized to the cloud platform and a REST API is available to access the información from external systems.

## Developing Custom Interfaces
Here is a very rough guide to develop custom interfaces for MAPS:

1. Clone this repository with the following command:

```
git clone https://github.com/wfpcoslv/
```

2. Open the "examples" folder and duplicate one of the existing examples:

```
cd examples
cp -r SV_Generic_SimpleExample MyExample
```

3. Edit the "cdp.proto" to define the variables to be captured using the Protocol Buffers definition syntax.

```
vim MyExample/cdp.proto
```

4. You might want to generate test data to match the protocol buffer definition file. Edit the test_data.js file to make those changes:

```
vim MyExample/test_data.js
```

5. To edit the data capture interface edit the "new_coresp.html" file. Take a look to the init() and addEntry() functions. Match the variables with the ones defined on cdp.proto

```
vim MyExample/new_coresp.html
```

6. To preview your work in a browser window run the following make command:

```
make project=MyExample capture_test
```

7. To edit the data visualization interface edit the "view_list_coresp.html" file. Again, take a look to the init() funcion.

```
vim MyExample/view_list_coresp.html
```

8. To preview your work in a browser window run the following make command:

```
make project=MyExample view_test
```

9. When you are ready to deploy just run the following command and upload the generated zipfile under the folder output to the Maps Cloud Platform.

```
make project=MyExample
```

10. In case you want to cleanup all the temporary files just run:

```
make project=MyExample clean
```

## Do you want to join us?
All the capture-interfaces and API clients on this repository are free to use and Open-Source for all humanitarian purposes. If you are a developer working for a local government, UN-Agency or NGO and want to contribute to develop other use-cases or interfaces for MAPS, just clone this repository and send us your pull-request to include your applications and examples.

## Do you want to test MAPS on real-life devices?
All the development of MAPS is currently coordinated from the World Food Programme El Salvador Office. If you are interested to deploy maps on a real-life scenario or want to test MAPS on your organization you can reach us via email:

* [Federico Naccarato](mailto:federico.naccarato@wfp.org) / WFP Innovation Office MAPS Project Manager
* [Claudia Rodriguez](claudia.rodriguez@wfp.org) / WFP El Salvador Country Office MAPS Project Manager
* [Mario Gómez](mario.gomez@wfp.org) / Technical Advisor