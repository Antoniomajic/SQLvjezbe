import React, { Component } from "react";
import { Button, Container, Table } from "react-bootstrap";
import CustomerDataService from "../../services/customer.service";
import { Link } from "react-router-dom";
import {FaEdit, FaTrash} from "react-icons/fa";


export default class Customers extends Component{
    constructor(props){
        super(props);
        this.fetchCustomers = this.fetchCustomers.bind(this);
        this.deleteCustomer = this.deleteCustomer.bind(this);

        this.state = {
            customers: []
        };
    }

    componentDidMount(){
        this.fetchCustomers();
    }

    async fetchCustomers(){
        await CustomerDataService.get()
        .then(response => {
            this.setState({
                customers: response.data
            });
            console.log(response.data);
        })

        .catch(e =>{
            console.log(e);
        });

    }

    async deleteCustomer(id){
        const answer = await CustomerDataService.delete(id);
        if(answer.ok){
            this.fetchCustomers();
        }else{
            alert(answer.message);
        }
    }



    render(){

        const { customers } = this.state;

        return(
            <Container>
                <a href="/customers/add" className="btn btn-success gumb">
                    Add new customer
                </a>

                <Table striped bordered hover responsive>
                    <thead>
                        <tr>
                            <th>First Name</th>
                            <th>Last Name</th>                            
                            <th>Contact</th>
                        </tr>
                    </thead>
                    <tbody>
                       { customers && customers.map((customer, index) => (

                        <tr key={index}>
                            <td>{customer.firstName}</td>
                            <td>{customer.lastName}</td>
                            <td>{customer.contact}</td>
                            <td>
                                <Link className="btn btn-primary gumb"
                                to={`/customers/${customer.id}`}>
                                    <FaEdit />
                                </Link>
                                <Button variant="danger" className="gumb"
                                onClick={()=>this.deleteCustomer(customer.id)}>
                                    <FaTrash />
                                </Button>
                            </td>
                        </tr>

                       )) }
                    </tbody>

                </Table>

            </Container>


            


        );
    }
}