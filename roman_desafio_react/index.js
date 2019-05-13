/**
 * @format
 */

import {AppRegistry} from 'react-native';
import Login from './src/pages/login';
import Navigate from './src';
//import Listar_Temas from './src/pages/listar_temas'; //colocada aqui para teste
import {name as appName} from './app.json';

AppRegistry.registerComponent(appName, () => Navigate);
//Faz com que o Login seja a primeira página a aparecer quando o emulador é aberto.
