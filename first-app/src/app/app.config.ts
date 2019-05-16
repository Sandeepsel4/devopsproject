import * as angular from 'angular';

export const moduleName = 'app';

export const appConstants: angular.IModule = angular
    .module(moduleName, [])
    .constant({
		"configValue1": "Sandeep",
        "configValue2": "#{app.ConfigValue2}"
	})