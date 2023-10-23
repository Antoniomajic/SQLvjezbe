import http from "../http-common";

class CustomerDataService{

    async get(){
        return await http.get('/Customer');
    }

    async delete(id){
        const answer = await http.delete('/Customer/' + id)
        .then(response => {
            return {ok:true, message: 'Successfully deleted'};
        })
        .catch(e=>{
            return {ok: false, message: e.response.data};
        });

        return answer;
    }

}

export default new CustomerDataService();
