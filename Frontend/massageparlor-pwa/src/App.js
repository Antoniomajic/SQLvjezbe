import React from 'react';
import './App.css';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import MainMenu from './components/mainmenu.component';
import Home from './components/home.component';
import Dashboard from './components/dashboard.component';
import Customers from './components/customer/customers.component';


export default function App() {
  return (
    <Router>
      <MainMenu />
      <Routes>
        <Route path='/' element={<Home />} />
        <Route path='/dashboard' element={<Dashboard />} />
        <Route path='/customers' element={<Customers />} />
      </Routes>

    </Router>
  );
}


