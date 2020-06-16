
# react-native-cardview

## Getting started

`$ npm install react-native-cardview --save`

### Mostly automatic installation

`$ react-native link react-native-cardview`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-cardview` and add `RNCardview.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNCardview.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.cardinfolink.cardview.RNCardviewPackage;` to the imports at the top of the file
  - Add `new RNCardviewPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-cardview'
  	project(':react-native-cardview').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-cardview/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-cardview')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNCardview.sln` in `node_modules/react-native-cardview/windows/RNCardview.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Cardview.RNCardview;` to the usings at the top of the file
  - Add `new RNCardviewPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNCardview from 'react-native-cardview';

// TODO: What to do with the module?
RNCardview;
```
  