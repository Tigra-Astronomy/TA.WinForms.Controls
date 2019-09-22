# Windows Forms Controls by Tigra Astronomy

## Introduction

The Tigra Windows Forms Controls library offers cadenced (blinking) status indicators of various kinds, plus the facility for user-written controls to benefit from cadenced behaviour.

Tigra Astronomy uses these controls extensively in ots own software, notably in ASCOM driver user interfaces. The controls have been part of the ASCOM Platform for more than a decade at the time of writing, and this is an updated and improved version of that library.

The library provides the following controls:

- Annunciator
- Annunciator Panel
- LED Indicator

The weather safety monitor application used in our robotic observatory is a great example of the controls in use.

![TAO SkyNet Weather Safety System][SkyNet-annotated]

## Overview

The library consists of the following main classes (plus other miscellaneous supporting helper classes):
![Class Diagram][cd]

The various classes and controls will now be presented in detail.

## AnnunciatorPanel

from [Wikipedia][wiki-annunciator]:
> An __annunciator panel__, also known in some aircraft as the __Centralized Warning Panel (CWP)__ or __Caution Advisory Panel (CAP)__, is a group of lights used as a central indicator of status of equipment or systems in an aircraft, industrial process, building or other installation. Usually, the annunciator panel includes a main warning lamp or audible signal to draw the attention of operating personnel to the annunciator panel for abnormal events or condition.

![A typical aviation-style annunciator panel][annunciator-image]

The `AnnunciatorPanel` control is designed to simulate the look and feel of the physical panels that are often found in aviation. These provide logical groupings of indicators while being well-suited for use in a low-light environment such as an observatory or aircraft cockpit. The dark background provides high contrast for alarm indications, reduces eyestrain and helps to preserve dark-adapted vision.

This container control is essentially a `FlowLayoutPanel` with some default styling choices that are designed to emulate the look and feel of a real annunciator panel and is recommended as a good choice for hosting `Annunciator` controls in most situations. However, it is not a requirement and annunciators can be placed anywhere on a design surface.

`AnnunciatorPanel` acts as a handy default container for groups of `Annunciator` controls but is otherwise completely optional. `Annunciator` and `LedIndicator` controls can be placed anywhere on a design surface, but in the absence of a compelling reason otherwise, it is recommended to place annunciators on an `AnnunciatorPanel`.

## Annunciator

The `Annunciator` control simulates an individual status or warning indocation. They have `Text` and otherwise act a lot like `Label` controls and are in fact derived from the `Label` control. `Annunciator` has the concept of `ActiveColor` and `InactiveColor` which represent the appearance when the lamp is on or off, respectively. They also have a `Cadence` which controls whether the lamp is steadily illuminated or whether it blinks on and off in a variety of predefined patterns.

### `Text` property

The text of a real annunciator is often fixed and part of a manufactured panel. When the annunciator is on, a lamp shines through the text, which is a clear, unprinted part of the panel and so the words are illuminated in high contrast.

In software, we have more flexibility and so we can allow the text to change to adapt to different situations. There are situations where this makes sense but care should be taken when designing annunciators that chage their text. A more typical use, applying the "principle of least astonishment", would be for each annunciator to have a short, fixed label and for the cadence (and possibly colour) to vary to differentiate different situations and warnings.

In the SkyNet Weather Safety application shown in the introduction, we have both types.

- At the top we have a small panel dedicated to showing the overall safety state. Rather than changing the text of an annunciator, we have used separate controls for "Safe", "Warning" and "Unsafe". The text remains fixed and we illuminate whichever control is appropriate at the time. The only change to the controls at runtime is that we toggle the `Mute` property on or off and all other settings remain constant. This is the recommended typical usage pattern of an annunciator.

- At the bottom is a large panel that is used to display readings from weather sensors. These items change their text over time, and also change their colour depending on how they contribute to the overall safety status. This panel leverages the flow layout behaviour of the `AnnunciatorPanel` as the size of the controls is not known in advance.

Thus, the user can see at a glance the overall safety state in the top panel, and when the system is unsafe, the user can see which of the sensor values is contributing to that state.

In a sense, these sensor readings are not true annunciators because they deviate from the classical behaviour of real-life panels. However, with careful design and avoidance of gratuitous over-use, this style of display is often useful and can provide a lot of flexibility in displaying information in a clear and compact form.

## `ActiveColor` property

This property controls the appearance of the text when the annunciator is "active" (illuminated). The colour should be chosen to provide a high contrast with the panel background.

## `InactiveColor` property

This property controls the text appearance when the annunciator is "inactive" (not illuminated). The colour should be chosen to provide a low contrast with the panel background.

The default colour is slightly brighter than the panel background such that the indicator is clearly off but nevertheless still just readable. This style choice is intended to mimic real panels where the text is physically etched into a panel and is often still readable when inactive. This also gives the user a visual cue as to what indications they may potentially experience in the future. Users seem to like this, but this is very much an individual design choice and the active and inactive colours can be set to any colour.

## Cadence property

> [Cadence][dic-cadence]: the beat, time, or measure of rhythmical motion or activity

This property sets the pattern with which the annunciator will blink (alternate between `ActiveColor` and `InactiveColor`) when unmuted. A number of predefined patterns are provided in the `CadencePattern` enumeration.

It was decided to provide a set of standard patterns to promote a consistent look and feel across applications. The user can, with some ingenuity, set the `CadencePattern` to any unsigned integer value. The blink pattern is determined by the binary representation of the `CadencePattern` property.

## `CadencePattern` enumeration

This enumeration provides the following standard candence patterns.

Name          | BitPattern | Description
--------------|------------|------------
`SteadyOff`   | 0x00000000 | Permanently off; appropriate for indication of a non-critical inactive state.
`SteadyOn`    | 0xFFFFFFFF | Permanently on; appropriate for indication of a non-critical active state.
`BlinkFast`   | 0xF0F0F0F0 | appropriate for indicating a state of hightened but non-critical alert. Usage example: during movement of robotic equipment.
`BlinkSlow`   | 0xFF00FF00 | appropriate for non-critical persistent conditions. Usage example: image exposure in progress.
`BlinkAlarm`  | 0xAAAAAAAA | Very fast blink; appropriate for drawing attention to urgent conditions that may require operator intervention. Usage example: Rain detected, requiring emergency observatory closure
`Strobe`      | 0x00000001 | Occasional short blip on; appropriate for indicating non-critical ongoing steady idle state.
`Wink`        | 0xFFFFFFFE | Mostly on with an occasional short off period; appropriate for indicating non-critical ongoing steady active state. Example: telephone call on hold, don't forget about the caller!
`Pulse1`      | 0x00000003 | One pulse per cadence cycle. Can be useful for indicating different phases of an operation in progress.
`Pulse2`      | 0x00000033 | Two pulses per cadence cycle. Can be useful for indicating different phases of an operation in progress.
`Pulse3`      | 0x00000333 | Three pulses per cadence cycle. Can be useful for indicating different phases of an operation in progress.
`Pulse4`      | 0x00003333 | Four pulses per cadence cycle. Can be useful for indicating different phases of an operation in progress.
`Heartbeat`   | 0x0000000A | A distinct double pulse reminiscent of a human heart beat. Appropriate for an ongoing base confidence indication that a system is running; particularly in embedded systems.
`Offbeat`     | 0x000A0000 | Similar to `Heartbeat` but "syncopated" or "on the off-beat"

Note: enumerated types are stored internally as integers. `CadencePattern` is defined thus: `public enum CadencePattern : uint {}` and therefore the underlying storage is an `unsigned int`, which is a 32-bit value. This allows for a 32-bit cadence pattern which is replayed over approximately 5 seconds at a rate of about 125 milliseconds per bit. While it is not possible to assign a custom cadence within the designer, this may be accomplished programmatically like so:

```lang=custom
private void Form1_Load(object sender, EventArgs e)
{
    var customCadence = (CadencePattern) 0x01545451; // 00000001010101000101010001010001
    NonstandardAnnunciator.Cadence = customCadence;
}
```

### Inherited properties

`Annunciator` inherits from `Label` so offers all of the formatting and behaviour of a label. Specifically, it is useful to set the font size and typeface to match the look and feel of your aplication. Another useful facility is the `FlowBreak` property, which is available when an annuniator is placed within an `AnnunciatorPanel` or `FlowLayoutPanel` and forces the layout engine to begin a new row or column.

## `CadencedControlUpdater` classical

This is a singleton that provides the timing for cadence updates. Things are arranged such that each control's cadence is synchronized with all other cadenced controls, giving a pleasing "in sync" user interface rather than a mish-mash of unsynchronized controls.

Cadences are updated at a rate of about 1 bit every 125 milliseconds, but updates are not deterministic because they must happen on the UI thread and therefore must be posted to the Window message queue. Updates are performed asynchronously (while avoiding cross-thread control updates) and so should not block the UI thread unnecessarily.

The `Annunciator` and `LedIndicator` controls are constructed so as to register themselves by calling `CadencedControlUpdater.Add()` as they are created and to unregister by calling `CadencedControlUpdater.Remove()` as they are disposed. User-written controls should probably follow this pattern.

## `ICadencedControl` interface and User Written Controls

Users may create their own controls that benefit from cadenced behaviour by implementing the `ICadencedControl` interface. Such controls may then register themselves with the `CadencedControlUpdater` by calling `CadencedControlUpdater.Add()` and unregister themselves by calling `CadencedControlUpdater.Remove()`. Typically, registration happens inthe control's constructor and removal happens in the control's `Dispose()` method or finalizer.

The user-written control must then provide a `Cadence` property that allows its cadence to be written and read, plus a `CadenceUpdate(bool state)` method that is responsible for setting the control's appearance based on the `state` boolean. Controls in the library set the control's colour, but user-written controls can take any appropriate action.

Any exception generated while updating a control's cadence wil result in it being considered "rogue" and it will be removed from the update list and receive no further updates.

Items registered with the `CadencedControlUpdater` need not be Windows Forms Controls. Any object may implement the `ICadencedControl` interface and participate in cadenced updates by providing custom business logic within the `CadenceUpdate()` method.

### Threading Considerations

The `CadencedControlUpdater` singleton captures the synchronization context where it is created. This is normally in the user interface thread, which is a Single Threaded Apartment `[STAThread]`. Control updates then occur within that synchronization context, to ensure that no cross-threaded control updates occur (WinForms is not thread safe).

The `CadencedControlUpdater` singleton uses lazy instantiation so it is possible to control when creation happens and to create this singleton within other threading models. In that case, updates will always occur in the thread in which the singleton is created. Updates occur asynchronously but there is no attempt at parallelism and updates will always occur in sequence.

[tigra]: http://tigra-astronomy.com "Tigra Astronomy Web Site"
[project]: http://tigra-astronomy.com "TA.WinFormsControls project page"
[code]: https://github.com/Tigra-Astronomy/TA.WinForms.Controls "Source code repository and issue tracker"
[SkyNet-annotated]: assets/SkyNet-annotated.png "Screen capture of the SkyNet Weather Safety System in operation"
[wiki-annunciator]: https://en.wikipedia.org/wiki/Annunciator_panel "Wikipedia: Annunciator Panel"
[annunciator-image]: assets/ah500-annunciator-panel.png "Aviation-style annunciator panel"
[dic-cadence]: https://www.merriam-webster.com/dictionary/cadence "Merriam Webster online dictionary"
[cd]: assets/Controls.png "Class Diagram (only public API methods and properties shown)"