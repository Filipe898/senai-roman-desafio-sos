import React, {Component} from 'react';
import {StyleSheet, Text, View} from 'react-native';

import {
    StyleSheet,
    View,
    Text,
    Image,
    ImageBackground,
    TextInput,
    TouchableOpacity,
    AsyncStorage
  } from "react-native";
  
import api from "../services/api";

class Listar_Temas extends Component {
  render() {
    return (
      <View style={styles.container}>
        <Text style={styles.welcome}>LOGIN FEITO. LOGIN FEITO</Text>       
      </View>
    );
  }
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: '#F5FCFF',
  },
  welcome: {
    fontSize: 20,
    textAlign: 'center',
    margin: 10,
  },
});

export default Listar_Temas;