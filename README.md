# COMSM0129: Augmenting the Real World

Source code for COMSM0129 ARW lab sessions.

---

## Prerequisites

Before opening any project, make sure you have the following installed:

1. **Unity Hub** (latest version)
2. **Unity Editor 6000.0.59f2** — install via Unity Hub > Installs > Install Editor > Archive, or directly from the [Unity Download Archive](https://unity.com/releases/editor/archive)
3. During Unity installation, make sure to add the **Android Build Support** module (including **Android SDK & NDK Tools** and **OpenJDK**)
4. **Git** — to clone this repository

> **Important:** You must use the exact Unity version **6000.0.59f2**. Opening the project with a different version may cause compatibility issues.

---

## How to Clone This Repository

```bash
git clone https://github.com/<your-org>/COMSM0129_ARW.git
```

Or download the ZIP from the repository page and extract it.

---

## Project Structure

```
COMSM0129_ARW/
├── lab1/
│   ├── ARW_Lab_1.pdf          # Lab 1 instructions
│   ├── lab1_phone/            # Unity project for Google Pixel (Task 1 & 2)
│   │   ├── Assets/
│   │   ├── Packages/
│   │   └── ProjectSettings/
│   └── lab1_Meta/             # Unity project for Meta Quest HMD (Task 3)
│       ├── Assets/
│       ├── Packages/
│       └── ProjectSettings/
├── lab2/
│   ├── ARW_Lab_2.pdf          # Lab 2 instructions
│   └── lab2/                  # Unity project for Lab 2 (Pixel phone)
│       ├── Assets/
│       ├── Packages/
│       └── ProjectSettings/
├── lab3/
│   ├── ARW_Lab_3.pdf          # Lab 3 instructions
│   └── lab3/                  # Unity project for Lab 3 (Pixel phone)
│       ├── Assets/
│       ├── Packages/
│       └── ProjectSettings/
├── lab4/
│   ├── ARW_Lab_4.pdf          # Lab 4 instructions
│   └── lab4/                  # Unity project for Lab 4 (Pixel phone)
│       ├── Assets/
│       ├── Packages/
│       └── ProjectSettings/
└── README.md
```

> **IMPORTANT: `lab1_phone/` and `lab1_Meta/` are two completely separate Unity projects.** They have different packages, different XR plugins, and different project settings. **Do NOT mix their settings or copy settings from one to the other.** Always open them as independent projects in Unity Hub.

- **`Assets/`** — Scenes, prefabs, scripts, URP settings, XR settings.
- **`Packages/`** — Package dependencies. Unity downloads them automatically on first open.
- **`ProjectSettings/`** — Build settings, player settings, XR Plug-in Management config, etc.

> The `Library/`, `Logs/`, `Temp/`, and other regenerable folders are **not** included in the repository. Unity will regenerate them automatically when you first open each project.

### Building on Lab 1 for Future Labs

You can use the Lab 1 projects as a starting point for later labs. There is no need to create a new Unity project from scratch each time — simply continue working in the `lab1_phone/` or `lab1_Meta/` project and add new scenes, scripts, and assets as needed.

---

## Lab 1 — Task 1 & 2: Google Pixel Phone (`lab1_phone/`)

### Step 1: Open in Unity Hub

1. Open **Unity Hub**.
2. Click **Open** (or **Add** > **Add project from disk**).
3. Navigate to the project folder `lab1/lab1_phone/` and select it.
4. Unity Hub should detect the project and show it in your project list.

### Step 2: Wait for Import

1. Click on the project to open it in Unity Editor.
2. **The first time you open the project, Unity will regenerate the `Library/` folder and import all assets. This can take several minutes.** Be patient and do not close Unity during this process.
3. You may see a prompt about the Unity version — make sure you are using **6000.0.59f2**.

### Step 3: Handle the "Unsupported Input Handling" Dialog

When the project opens for the first time, you will see a dialog saying:

> **Unsupported Input Handling**
> PlayerSettings->Active Input Handling is set to Both, this is unsupported on Android and might cause issues with input and application performance.

**Click "Yes"** to ignore and continue. This dialog will not appear again in the same Editor session.

### Step 4: Switch to Android Platform

1. Go to **File > Build Profiles**.
2. Check if **Android** is already selected as the active platform.
3. If not, select **Android** from the platform list and click **Switch Platform**. This may take a few minutes as Unity reimports assets for the new platform.

### Step 5: Load the Scene

When the project first opens, you may see an empty "Untitled" scene instead of the actual AR scene. You need to load the correct scene manually:

1. In the **Project** window (bottom panel), navigate to `Assets/Scenes`.
2. You will find the `SampleScene` and drag it to the editor.
3. You should now see the scene hierarchy with **AR Session** and **XR Origin** components.

### Step 6: Add Scene to Build

1. Go to **File > Build Profiles**.
2. In the **Scene List** section, click **Add Open Scenes** to add the currently opened scene.
3. If there is an "Untitled" scene in the list, select it and click the **-** button (or right-click > Remove) to delete it.
4. Make sure only the scene you want to build is checked in the list.

### Step 7: Verify Packages (Optional)

1. Go to **Window > Package Manager**.
2. Verify that the following packages are installed:
   - **AR Foundation**
   - **Google ARCore XR Plugin**
3. If any packages show errors, try clicking **Window > Package Manager > Refresh** or restarting Unity.

---

## How to Build and Run on Android (Google Pixel)

### Step 1: Verify Build Platform

1. Go to **File > Build Profiles**.
2. Make sure **Android** is selected as the active platform (you should have already done this in Step 4 above).

### Step 2: Connect Your Phone

1. Enable **Developer Mode** on your Google Pixel phone:
   - Go to **Settings > About Phone** and tap **Build Number** 7 times.
2. Enable **USB Debugging**:
   - Go to **Settings > Developer Options > Debugging** and enable **USB Debugging**.
3. Make sure **Google Play Services for AR** (ARCore) is installed from the Play Store.
4. Connect the phone to your computer via USB cable.
5. If prompted on the phone, tap **Allow USB Debugging**.

### Step 3: Build and Run

1. In **File > Build Profiles**, under **Run Device**, click **Refresh** and select your phone.
2. Click **Build And Run**.
3. Choose a location to save the APK, then wait for the build to complete.
4. The app will launch on your phone automatically.

---

## Lab 1 — Task 3: Meta Quest HMD (`lab1_Meta/`)

> **This is a separate Unity project from the phone project above.** Do NOT open `lab1_Meta/` in the same Unity editor as `lab1_phone/`. They have completely different packages (Meta XR SDK vs AR Foundation) and project settings.

### Step 1: Open in Unity Hub

1. Open **Unity Hub**.
2. Click **Open** and navigate to `lab1/lab1_Meta/`.
3. Open the project in Unity Editor and wait for the import to complete.

### Step 2: Handle Dialogs

- If the **"Unsupported Input Handling"** dialog appears, click **Yes**.
- If prompted about Meta XR settings or Project Validation issues, follow the prompts or click **Fix All**.

### Step 3: Switch to Android Platform

1. Go to **File > Build Profiles**.
2. Select **Android** and click **Switch Platform** if not already active.

### Step 4: Load the Scene

1. In the **Project** window, navigate to `Assets/Scenes/`.
2. Double-click **SampleScene.unity** to open it.
3. If prompted to save the "Untitled" scene, click **Don't Save**.
4. You should see the Meta Quest scene with **OVRCameraRig**, Passthrough, and Grab Interaction components.

### Step 5: Add Scene to Build

1. Go to **File > Build Profiles**.
2. Click **Add Open Scenes** to add the current scene.
3. Remove any "Untitled" scene from the list.

### Step 6: Build and Run on Quest

1. Connect your Meta Quest headset via USB-C cable.
2. Put on the headset and accept the **"Allow USB debugging"** prompt if it appears.
3. In **File > Build Profiles**, click **Refresh** under **Run Device** and select your Quest device.
4. Click **Build And Run** and choose a location to save the APK.
5. The app will launch automatically on the headset. You should see passthrough mode with a virtual cube you can grab.

---

## Lab 2 & 3 — Important Note: Robot Prefab Material Fix
These project is based on the same phone project from Lab 1. Open it the same way as `lab1_phone/`.

 Or open `lab2/lab2` or `lab3/lab3` in Unity Hub. The steps (import, handle dialogs, switch to Android, load scene, add to build, build and run) are the same as Lab 1 — refer to the Lab 1 instructions above.

Labs 2 and 3 use a robot prefab from the `MobileARCourse` package. This prefab uses **Built-in Render Pipeline materials**, which are **invisible on Android** in our URP project.
You must convert the materials before building.

### Fix the Robot Materials

1. In the Project window, navigate to `Assets/MobileARCourse/Materials/`.
2. Select **all materials** in the folder (Cmd+A).
3. Go to **Edit > Rendering > Materials > Convert Built-in Materials to URP**.
4. The materials will be upgraded. However, the robot prefab's child objects may still reference the old embedded materials.
5. **Double-click** the `robot` prefab (in `MobileARCourse/Prefabs/`) to enter Prefab Mode.
6. Click each child object (head, body, etc.), find **Mesh Renderer > Materials** in the Inspector, and drag `MobileARCourse/Materials/RobotMat` into the material slot.
7. Save and exit Prefab Mode.

After this fix, the robot preview should change from **pink/magenta** to its normal textured appearance.

### Fix the Robot Rigidbody

The robot prefab has a **Rigidbody** with **Use Gravity = true**. In AR, there is no physical ground, so the robot will fall through the plane and disappear instantly after spawning.

1. Open the `robot` prefab.
2. Select the **Rigidbody** component.
3. **Uncheck Use Gravity** and **check Is Kinematic**.

### Lab 3 Task 3: Using a New Script for 3D Motions

If you created a new script for Task 3 (e.g. `motionsManager`) to handle image tracking with animations, remember to:

1. **Uncheck** (disable) the old `AR Unit Lab` script on XR Origin — otherwise both scripts will run and conflict with each other.
2. Make sure your new script (e.g. `Motions Manager`) is **checked** (enabled).
3. The `AR Tracked Image Manager` component should have **Tracked Image Prefab** set to **None** (as instructed), since your new script handles instantiation manually.

---

## Lab 4 — Intelligent Tracking (`lab4/lab4/`)

This project is based on the same phone project from Lab 1. Open it the same way as `lab1_phone/`.

or open `lab4/lab4/` in Unity Hub. The steps (import, handle dialogs, switch to Android, load scene, add to build, build and run) are the same as Lab 1 — refer to the Lab 1 instructions above.

### Lab 4 Supplementary Notes

Please read these notes carefully before troubleshooting. Some features in Lab 4 have **platform limitations** on ARCore (Android).

#### Task 1 — Plane Classification

- **If all detected planes are red
 (Other):** This is normal behaviour and means your code is running correctly. Plane classification (Semantics) requires:
  - A **supported device** (e.g. Pixel 8 with the latest ARCore). Older devices may classify all planes as `None`, which falls into the `else` (Other/red) branch.
  - **Sufficient lighting** and enough scanning time. Move the phone slowly around the room, scanning floors and tables from multiple angles for at least 30 seconds.
  - Planes are often detected as `None` first and reclassified later. The red colour may change to green (Floor) or blue (Table) after continued scanning.
- **As long as you can see red planes appearing on surfaces, your code is working.** The classification accuracy depends on the device and environment, not your code.

#### Task 2 — Human Body Tracking

- **`ARHumanBodyManager` is an ARKit (iOS) feature and is NOT supported on ARCore (Android/Pixel).** This means body tracking will never detect a person on Pixel phones.
- **If the app shows "Scanning..." on screen, your code is correct.** This means:
  - The AR subsystem started successfully.
  - The `BodyDebug` script is running and checking for bodies.
  - No body is detected because ARCore does not provide body tracking data.
- **If the app shows "AR Subsystem Stopped!", something is wrong** — check your AR Human Body Manager configuration.
- The purpose of this task is for you to learn how to write body tracking code using AR Foundation's API. Seeing "Scanning..." confirms your implementation is correct, even though the feature is not available on Android.

#### Task 3 — Environment Occlusion

- **Environment Depth** works on supported Pixel devices (Pixel 4+). You should be able to see real-world objects occluding the virtual cube.
- **Human Segmentation Stencil/Depth Mode** is ARKit-only and will have no effect on Android. You can still set it to "Best" in the Inspector, but it will not do anything on the Pixel phone. Only the **Environment Depth Mode** setting matters for ARCore.

---

## Troubleshooting

| Problem | Solution |
|---------|----------|
| **Scene is empty / shows "Untitled" after opening project** | The scene does not auto-load. Go to the Project window, navigate to `Assets/`, and double-click the `.unity` scene file you want (e.g. `sample.unity` or `ar_plane.unity`). See Step 5 above. |
| **"Unsupported Input Handling" dialog appears** | Click **Yes** to ignore and continue. This is expected and will not appear again in the same session. |
| **Build fails / wrong platform** | Make sure you switched to **Android** platform: **File > Build Profiles > Android > Switch Platform**. See Step 4 above. |
| **"Version mismatch" warning on open** | Install the exact Unity version **6000.0.59f2** via Unity Hub. |
| **Packages fail to resolve / errors on import** | Delete the `Library/` folder inside the project and reopen Unity to force a clean reimport. |
| **"No Android module" error** | In Unity Hub, go to **Installs**, click the gear icon on your Unity version, select **Add Modules**, and install **Android Build Support** (with SDK, NDK, and JDK). |
| **Build fails with Vulkan error** | Go to **File > Build Profiles > Player Settings > Other Settings**, deselect **Auto Graphics API**, and remove **Vulkan** from the list. This should already be configured, but double-check. |
| **Phone not detected in Run Device** | Make sure USB Debugging is enabled, the phone is connected, and you clicked **Refresh** in Build Profiles. |
| **AR features not working on phone** | Ensure **Google Play Services for AR** is installed on the phone from the Play Store. |
| **Camera background is black / not showing** | Verify that `Assets/Settings/Mobile_Renderer.asset` has the **AR Background Renderer Feature** added. Select it in the Project window and check the Inspector. |
| **(Lab 4) All planes are red / no classification** | This is expected on many devices. See Lab 4 Supplementary Notes above. Scan slowly for 30+ seconds with good lighting. |
| **(Lab 4) Body tracking shows "Scanning..." forever** | This is expected on Android. ARHumanBodyManager is ARKit-only. "Scanning..." means your code is correct. See Lab 4 Supplementary Notes. |
| **(Lab 4) Occlusion not working** | Ensure **Environment Depth Mode** is set to **Best** on the AROcclusionManager. Human Segmentation modes are ARKit-only and won't work on Pixel. |

---

## Questions?

If you encounter any issues, please contact your TA or post on the unit's discussion forum.
