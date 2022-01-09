import {Store,Module,ActionContext} from 'vuex'
import ListModule from './list-module'
import ListState from './list-state'
import DoTask from '../entities/do-task'
import Ajax from '../../lib/ajax'
import PageResult from '@/store/entities/page-result';
import ListMutations from './list-mutations'
interface DoTaskState extends ListState<DoTask>{
    editDoTask:DoTask;
}
class DoTaskModule extends ListModule<DoTaskState,any,DoTask>{
    state={
        totalCount:0,
        currentPage:1,
        pageSize:10,
        list: new Array<DoTask>(),
        loading:false,
        editDoTask:new DoTask()
    }
    actions={
        async getAll(context:ActionContext<DoTaskState,any>,payload:any){
            context.state.loading=true;
            let reponse=await Ajax.get('/api/services/app/DoTask/GetAll',{params:payload.data});
            context.state.loading=false;
            let page=reponse.data.result as DoTask[];
            context.state.totalCount=page.length;
            context.state.list=page;

        },
        async create(context:ActionContext<DoTaskState,any>,payload:any){
            await Ajax.post('/api/services/app/DoTask/Create',payload.data);
        },
        async update(context:ActionContext<DoTaskState,any>,payload:any){
            await Ajax.put('/api/services/app/DoTask/Update',payload.data);
        },
        async delete(context:ActionContext<DoTaskState,any>,payload:any){
            await Ajax.delete('/api/services/app/DoTask/Delete?Id='+payload.data.id);
        },
        async get(context:ActionContext<DoTaskState,any>,payload:any){
            let reponse=await Ajax.get('/api/services/app/DoTask/Get?Id='+payload.id);
            return reponse.data.result as DoTask;
        }
    };
    mutations={
        setCurrentPage(state:DoTaskState,page:number){
            state.currentPage=page;
        },
        setPageSize(state:DoTaskState,pagesize:number){
            state.pageSize=pagesize;
        },
        edit(state:DoTaskState,doTask:DoTask){
            state.editDoTask=doTask;
        }
    }
}
const doTaskModule=new DoTaskModule();
export default doTaskModule;