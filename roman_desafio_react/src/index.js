import {
    createBottomTabNavigator,
    createAppContainer,
    createStackNavigator,
    createSwitchNavigator
  } from "react-navigation";
  

  import Login from "./pages/login";
  import Listar_Temas from ".page/listar_temas";
  
  const AuthStack = createStackNavigator({ Login });
  
  const MainNavigator = createBottomTabNavigator(
    {
      //nome de uma página,
      Listar_Temas
    },
    {
      initialRouteName: "Listar_Temas",
      swipeEnabled: true,
      tabBarOptions: {
        showLabel: false,
        showIcon: true,
        inactiveBackgroundColor: "#dd99ff",
        activeBackgroundColor: "#B727FF",
        activeTintColor: "#FFFFFF",
        inactiveTintColor: "#FFFFFF",
        style: {
          height: 50
        }
      }
    }
  );
  
  //export default createAppContainer(MainNavigator);
  
  export default createAppContainer(
    createSwitchNavigator(
      {
        MainNavigator,
        AuthStack
      },
      {
        initialRouteName: "AuthStack"
      }
    )
  );
  