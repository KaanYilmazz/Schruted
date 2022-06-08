import Entity from './entity'

export default class DoTask extends Entity<number>{
    name:string;
    maxPoint:number;
    description:string;
}