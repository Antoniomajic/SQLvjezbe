import React, { Component } from "react";
import Container from 'react-bootstrap/Container';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import NavDropdown from 'react-bootstrap/NavDropdown';
import logo from '../logo.svg';


export default class MainMenu extends Component{
    render(){
        return(
            <Navbar expand="lg" className="bg-body-tertiary">
      <Container>
        <Navbar.Brand href="/"> <img className="App-logo" src={logo} alt="" /> Massage Parlor APP</Navbar.Brand>
        <Navbar.Toggle aria-controls="basic-navbar-nav" />
        <Navbar.Collapse id="basic-navbar-nav">
          <Nav className="me-auto">
            <Nav.Link href="/dashboard">Dashboard</Nav.Link>
            <NavDropdown title="Select option" id="basic-nav-dropdown">
              <NavDropdown.Item href="/customers">Customers</NavDropdown.Item>
              <NavDropdown.Item href="/appointments">
                Appointments
              </NavDropdown.Item>
              <NavDropdown.Item href="massages">Massages</NavDropdown.Item>
              <NavDropdown.Divider />
              <NavDropdown.Item target="_blank" href="/swagger/index.html">
                Swagger
              </NavDropdown.Item>
            </NavDropdown>
          </Nav>
        </Navbar.Collapse>
      </Container>
    </Navbar>


        );
    }
}