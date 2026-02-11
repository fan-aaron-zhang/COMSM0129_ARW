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
│   ├── ARW_Lab_1.pdf          # Lab instructions
│   └── lab1_phone/            # Unity project (Task 1 & 2: Google Pixel phone)
│       ├── Assets/            # Scenes, prefabs, scripts, settings
│       ├── Packages/          # Package dependencies (manifest.json)
│       └── ProjectSettings/   # All project & build settings
└── README.md
```

- **`Assets/`** — Contains all scenes, prefabs (AR Default Plane, AR Default Point Cloud), scripts, URP settings (with AR Background Renderer Feature already configured), and XR settings.
- **`Packages/`** — Defines which packages Unity should install (AR Foundation, Google ARCore XR Plugin, etc.). Unity will download them automatically.
- **`ProjectSettings/`** — Contains all the build settings, player settings, XR Plug-in Management config, etc. already configured for Android/ARCore.

> The `Library/`, `Logs/`, `Temp/`, and other regenerable folders are **not** included in the repository. Unity will regenerate them automatically when you first open the project.

---

## Lab 1 Instructions

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

1. In the **Project** window (bottom panel), navigate to `Assets/`.
2. You will find the following scene files:
   - **`sample.unity`** — Task 1 scene (AR Session + XR Origin, camera passthrough only)
   - **`ar_plane.unity`** — Task 2 scene (with AR Plane Manager + AR Point Cloud Manager)
3. **Double-click** the scene you want to open (e.g. `sample.unity` for Task 1, or `ar_plane.unity` for Task 2).
4. If prompted to save the current "Untitled" scene, click **Don't Save**.
5. You should now see the scene hierarchy with **AR Session** and **XR Origin** components.

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

## Pre-built APK

If you just want to see the app in action without building from source, a pre-built `.apk` file is available separately. Ask your TA for the download link.

<!-- TA: Replace this with your actual distribution link (e.g., Teams, OneDrive, Google Drive) -->

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

---

## Scenes Included

- **`Assets/sample.unity`** — Task 1: Basic AR Foundation scene with AR Session + XR Origin (camera passthrough only).
- **`Assets/ar_plane.unity`** — Task 2: AR scene with Plane Manager + Point Cloud Manager and their prefabs, showing detected planes and point clouds.
- **`Assets/Scenes/SampleScene.unity`** — Default URP sample scene (can be used as reference).

---

## Questions?

If you encounter any issues, please contact your TA or post on the unit's discussion forum.
