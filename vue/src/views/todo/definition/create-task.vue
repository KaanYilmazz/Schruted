<template>
    <div>
        <Modal
         :title="L('CreateNewTask')"
         :value="value"
         @on-ok="save"
         @on-visible-change="visibleChange"
        >
            <Form ref="taskForm"  label-position="top" :rules="taskRule" :model="doTask">
                <FormItem :label="L('Name')" prop="name">
                    <Input v-model="doTask.name" :maxlength="32" :minlength="2"></Input>
                </FormItem>
                <FormItem :label="L('Description')" prop="description">
                    <Input v-model="doTask.description" :maxlength="1024"></Input>
                </FormItem>
                <FormItem :label="L('MaxPoint')" prop="maxPoint">
                    <Input v-model="doTask.maxPoint" :maxlength="256"></Input>
                </FormItem>
            </Form>
            <div slot="footer">
                <Button @click="cancel">{{L('Cancel')}}</Button>
                <Button @click="save" type="primary">{{L('OK')}}</Button>
            </div>
        </Modal>
    </div>
</template>
<script lang="ts">
    import { Component,Prop } from 'vue-property-decorator';

    import AbpBase from '../../../lib/abpbase'
    import DoTask from '@/store/entities/do-task';
    @Component
    export default class CreateTask extends AbpBase{
        @Prop({type:Boolean,default:false}) value:boolean;
        doTask:DoTask=new DoTask();
        save(){            
            (this.$refs.taskForm as any).validate(async (valid:boolean)=>{
                if(valid){
                    await this.$store.dispatch({
                        type:'doTask/create',
                        data:this.doTask
                    });
                    (this.$refs.taskForm as any).resetFields();
                    this.$emit('save-success');
                    this.$emit('input',false);
                }
            })
        }
        cancel(){
            (this.$refs.taskForm as any).resetFields();
            this.$emit('input',false);
        }
        visibleChange(value:boolean){
            if(!value){
                this.$emit('input',value);
            }
        }
        taskRule={
            name:[{required: true,message:this.L('FieldIsRequired',undefined,this.L('Name')),trigger: 'blur'}],
            maxPoint:[{required:true,message:this.L('FieldIsRequired',undefined,this.L('MaxPoint')),trigger: 'blur'}]
        }
    }
</script>

